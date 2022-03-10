using Project_IPET.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IPET
{
    public partial class FrmProductPage : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Project_IPET.Properties.Settings.MyProjectConnectionString"].ToString();
        private int memberID = 1; //TODO MemberEntity.MemberID
        private int productID;
        public FrmProductPage(int productID = 0)
        {
            InitializeComponent();
            ShowProductList();
            CreatButton();
            this.productID = productID;
            //comboBox Show Categories Items and Brand
            LoadCategories();
            LoadBrand();
            //comboBox禁止編輯
            cbxProductBrandName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductSubCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        MyProjectEntities dbContext = new MyProjectEntities();
        private void btnNewFrm_Click(object sender, EventArgs e)
        {
           FrmProduct frmProduct= new FrmProduct(memberID);
            DialogResult dialogResult = frmProduct.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                frmProduct.ShowDialog();
            }
            ShowProductList();
        }

        private void ShowProductList()
        {
            ShowProductList(new ProductSearchFilter() { BrandID = -1, CategoryID = -1, SubCategoryID = -1, ProductName = "" });
        }

        private void ShowProductList(ProductSearchFilter filter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn; 
                    string sql = @"SELECT p.*,sc.SubCategoryName,c.CategoryName 
                                                FROM Products p 
                                                JOIN SubCategories sc ON p.SubCategoryID =sc.SubCategoryID 
                                                JOIN Categories c ON sc.CategoryID = c.CategoryID 
                                                WHERE 1=1";
                    if (!string.IsNullOrWhiteSpace(filter.ProductName)) //確認輸入的不是Null/空白鍵/""空字串
                    {
                        sql += " AND ProductName LIKE '%'+@ProductName + '%'";  //模糊比對->搜尋功能
                        command.Parameters.AddWithValue("@ProductName", filter.ProductName);
                    }

                    if (filter.CategoryID != -1)
                    {
                        sql += " AND c.CategoryID = @CategoryID";
                        command.Parameters.AddWithValue("@CategoryID", filter.CategoryID);
                    }

                    if (filter.SubCategoryID != -1)
                    {
                        sql += " AND sc.SubCategoryID = @SubCategoryID";
                        command.Parameters.AddWithValue("@SubCategoryID", filter.SubCategoryID);
                    }

                    if(filter.BrandID != -1)
                    {
                        sql += " AND p.BrandID =@BrandID";
                        command.Parameters.AddWithValue("@BrandID",filter.BrandID);
                    }


                    command.CommandText = sql;
                    SqlDataReader dataReader = command.ExecuteReader();
                    dgvProductList.Rows.Clear();
                    while (dataReader.Read())
                    {                      
                        dgvProductList.Rows.Add(dataReader["ProductID"],dataReader["ProductName"], dataReader["CategoryName"], dataReader["SubCategoryName"]);
                    }
                }

            }

            catch (Exception ex)
            {
                //寫LOG
                MessageBox.Show("");
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productID = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells["colProductID"].Value);
            if (e.ColumnIndex == 4)
            {
                //edit             
                FrmProduct frmProduct = new FrmProduct(memberID,productID);
                frmProduct.ShowDialog();
                ShowProductList();
            }
            else if(e.ColumnIndex == 5)
            {
                //delete
                DeleteProduct(productID); 
                ShowProductList();
            }
        }

        private void DeleteProduct(int pid)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            #region Delete ProductImage into ProductImagePath DB

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            byte[] bytes = ms.GetBuffer();
            //=========================
            command = new SqlCommand(@"DELETE FROM [dbo].[ProductImagePath] WHERE
                   ProductID=@ProductID", conn);

            command.Parameters.Add("@ProductID", SqlDbType.Int).Value = pid;
            command.Parameters.AddWithValue("@ProductImage", bytes);
            command.ExecuteNonQuery();
            #endregion

            #region Delete ProductDetails into Product DB

            command = new SqlCommand(@"DELETE FROM  [dbo].[Products] WHERE ProductID=@ProductID", conn);
            command.Parameters.Add("@ProductID", SqlDbType.Int).Value = pid;
            command.ExecuteNonQuery();
            #endregion


            conn.Close();
            MessageBox.Show("刪除產品成功！");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Show();
        }

        private void dgvProductList_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dgvProductList.CurrentRow.Cells[0].Value == null)
            {
                labShowProductID.Text = "";
                return;
            }
            int id = (int)this.dgvProductList.CurrentRow.Cells[0].Value;
            try
            {
                
                var q = from p in this.dbContext.Products
                        where p.ProductID == id
                        select p;
                foreach (var p in q)
                {
                    labShowProductID.Text =p.ProductName ;

                    pictureBoxShowProductImage.Image = null;
                    if (p.ProductImagePaths.Count > 0)
                    {
                        dbContext.Entry(p.ProductImagePaths.FirstOrDefault()).Reload();
                        MemoryStream oMemoryStream = new MemoryStream(p.ProductImagePaths.FirstOrDefault().ProductImage);
                        //設定資料流位置
                        oMemoryStream.Position = 0;  //Value目前位置設為0
                        pictureBoxShowProductImage.Image = Image.FromStream(oMemoryStream);
                    }
                    labShowProductCategory.Text = Convert.ToString(p.SubCategory.Category.CategoryName);  
                    labShowProductBrand.Text = Convert.ToString(p.Brand.BrandName);
                    labShowProductUnitPrice.Text = Convert.ToString(p.UnitPrice);
                    labShowProductUnitsInStock.Text= Convert.ToString(p.UnitsInStock);
                }

            }
            catch
            {
                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filter = new ProductSearchFilter() { 
                ProductName = txtSearchProduct.Text,
                CategoryID = Convert.ToInt32((cbxProductCategoryID.SelectedItem as ComboBoxItem).Value),
                SubCategoryID = Convert.ToInt32((cbxProductCategoryID.SelectedItem as ComboBoxItem).Value),
                BrandID = Convert.ToInt32((cbxProductBrandName.SelectedItem as ComboBoxItem).Value),
            };
            ShowProductList(filter);
        }

        private void CreatButton()
        {
            //在datagridview新增編輯按鈕
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvProductList.Columns.Add(btnEdit);
            btnEdit.HeaderText = "";
            btnEdit.Text = "編輯";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;

            //在datagridview新增刪除按鈕
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvProductList.Columns.Add(btnDelete);
            btnDelete.HeaderText = "";
            btnDelete.Text = "刪除";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
        }
        /// <summary>
        /// 載入All Brands到ComboBox
        /// </summary>
        private void LoadBrand()
        {
            //Show Brand 
            cbxProductBrandName.Items.Add(new ComboBoxItem { Text = "全部", Value = -1 });
            cbxProductBrandName.SelectedIndex = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"SELECT * FROM Brand", conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Text = dataReader["BrandName"].ToString();
                        item.Value = dataReader["BrandID"];
                        cbxProductBrandName.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                //寫LOG
                MessageBox.Show("載入品牌時錯誤");
            }
        }

        /// <summary>
        /// 載入All Categories到ComboBox
        /// </summary>
        private void LoadCategories()
        {
            cbxProductCategoryID.Items.Add(new ComboBoxItem { Text = "全部", Value = -1 });
            cbxProductCategoryID.SelectedIndex = 0;
            try
            {
                //Show Categories
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM Categories", conn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = dataReader["CategoryName"].ToString();
                    item.Value = dataReader["CategoryID"];
                    cbxProductCategoryID.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("載入主分類時錯誤");
            }
        }

        /// <summary>
        /// 按下編輯button後，會自動帶入產品資訊
        /// </summary>
        private void LoadProduct()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT p.*, sc.CategoryID FROM Products p JOIN SubCategories sc ON p.SubCategoryID = sc.SubCategoryID WHERE p.ProductID = @ProductID", conn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //自動顯示Categories
                    for (int i = 0; i < cbxProductCategoryID.Items.Count; i++)
                    {
                        if ((int)(cbxProductCategoryID.Items[i] as ComboBoxItem).Value == (int)dataReader["CategoryID"])
                        {
                            cbxProductCategoryID.SelectedIndex = i;
                            break;
                        }
                    }
                    //自動顯示SubCategories
                    for (int j = 0; j < cbxProductSubCategoryID.Items.Count; j++)
                    {
                        if ((int)(cbxProductSubCategoryID.Items[j] as ComboBoxItem).Value == (int)dataReader["SubCategoryID"])
                        {
                            cbxProductSubCategoryID.SelectedIndex = j;
                            break;
                        }
                        //自動顯示Brand
                        for (int k = 0; k < cbxProductBrandName.Items.Count; k++)
                        {
                            if ((int)(cbxProductBrandName.Items[k] as ComboBoxItem).Value == (int)dataReader["BrandID"])
                            {
                                cbxProductBrandName.SelectedIndex = k;
                                break;
                            }
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("載入商品時錯誤");
            }

        }

        private void cbxProductCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProductSubCategoryID.Items.Clear();
            cbxProductSubCategoryID.Items.Add(new ComboBoxItem { Text = "全部", Value = -1 });
            cbxProductSubCategoryID.SelectedIndex = 0;
            int categoryID = Convert.ToInt32((cbxProductCategoryID.SelectedItem as ComboBoxItem).Value);
            if (categoryID == -1)
            {
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM SubCategories WHERE CategoryID =@CategoryID ", conn);
                command.Parameters.AddWithValue("@CategoryID", categoryID);
                SqlDataReader dataReader = command.ExecuteReader();             
                while (dataReader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = dataReader["SubCategoryName"].ToString();
                    item.Value = dataReader["SubCategoryID"];
                    this.cbxProductSubCategoryID.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("選擇分類時發生錯誤");
            }
        }

        private void cbxProductBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ResetDataGridView()
        {
            dgvProductList.CancelEdit();
            dgvProductList.Columns.Clear();
            dgvProductList.DataSource = null;
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = ((int)this.dgvProductList.CurrentRow.Cells[0].Value);
                var q = this.dbContext.ProductImagePaths.Where(p => p.ProductID == id).Select(p => p);
                foreach(var p in q)
                {
                    MemoryStream ms = new MemoryStream(p.ProductImage);
                    this.pictureBoxShowProductImage.Image = Image.FromStream(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
