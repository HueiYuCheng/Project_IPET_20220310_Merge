using Project_IPET.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IPET
{
    public partial class FrmProduct : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Project_IPET.Properties.Settings.MyProjectConnectionString"].ToString();
        private bool editMode;
        private int memberID;
        private int productID;

        public FrmProduct(int memberID, int productID = 0)
        {
            InitializeComponent();
            this.editMode = productID != 0; // editMode = productID 是不是 不等於 0，如果productID=0，0"沒有"不等於0，所以是false->進入編輯模式。
            this.memberID = memberID;
            this.productID = productID;
            //comboBox Show Categories Items and Brand
            LoadCategories();
            LoadBrand();

            //comboBox禁止編輯
            cbxProductBrandName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductSubCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;

            if (this.editMode)
            {
                this.Text = "編輯";
                LoadProduct();

            }
            else
            {
                this.Text = "新增";
            }
        }

        private void cbxProductCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM SubCategories WHERE CategoryID =@CategoryID ", conn);
                command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32((cbxProductCategoryID.SelectedItem as ComboBoxItem).Value));
                SqlDataReader dataReader = command.ExecuteReader();
                cbxProductSubCategoryID.Items.Clear();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.editMode)
            {
                Update();
            }
            else
            {
                try
                {
                    #region 判斷input是否符合相符的資料type
                    //商品售價
                    decimal productPrice;
                    if (!decimal.TryParse(txtProductPrice.Text, out productPrice))
                    {
                        MessageBox.Show("productPrice請輸入數字");
                        return;
                    }
                    if (productPrice < 0)
                    {
                        MessageBox.Show("productPrice請輸入正整數");
                        return;
                    }
                    //庫存量
                    int unitsInStock;
                    if (!int.TryParse(txtUnitsInStock.Text, out unitsInStock))
                    {
                        MessageBox.Show("unitsInStock請輸入數字");
                        return;
                    }
                    if (unitsInStock < 0)
                    {
                        MessageBox.Show("unitsInStock請輸入正整數");
                        return;
                    }

                    #endregion
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();

                    #region Insert ProductDetails into Product DB
                    SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Products]
                   ([ProductName]
                   ,[SubCategoryID]
                   ,[BrandID]
                   ,[UnitPrice]
                   ,[UnitsInStock]
                   ,[Description]
                   ,[CreateMemberID]
                  ,[CreateDate]
                  ,[UpdateMemberID]
                  ,[UpdateDate])
                    VALUES
                  (@ProductName, @SubCategoryID, @BrandID, @UnitPrice, @UnitsInStock, @Description,@MemberID,GETDATE(),@MemberID,GETDATE())
                  SET @ID =SCOPE_IDENTITY() ", conn);

                    command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    command.Parameters.AddWithValue("@SubCategoryID", Convert.ToInt32((cbxProductSubCategoryID.SelectedItem as ComboBoxItem).Value));
                    command.Parameters.AddWithValue("@BrandID", Convert.ToInt32((cbxProductBrandName.SelectedItem as ComboBoxItem).Value));
                    command.Parameters.AddWithValue("@UnitPrice", productPrice);
                    command.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                    command.Parameters.AddWithValue("@Description", txtProductDescription.Text);
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    int id = Convert.ToInt32(command.Parameters["@ID"].Value);
                    #endregion

                    #region Insert ProductImage into ProductImagePath DB
                    //=========================
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.picBoxProductImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] bytes = ms.GetBuffer();
                    //=========================
                    command = new SqlCommand(@"INSERT INTO [dbo].[ProductImagePath]
                   ([ProductID],[ProductImage])
                    VALUES (@ProductID, @ProductImage) ", conn);

                    command.Parameters.AddWithValue("@ProductID",id);
                    command.Parameters.AddWithValue("@ProductImage", bytes);
                    //=========================
                    command.ExecuteNonQuery();
                    #endregion
                    conn.Close();
                    MessageBox.Show("新增產品成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }
        /// <summary>
        /// 載入All Brands到ComboBox
        /// </summary>
        private void LoadBrand()
        {
            //Show Brand 
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
                command.Parameters.AddWithValue("@ProductID", productID);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //編輯時自動顯示該產品的資訊，為了檢查combox裡面每個選項，到底哪個才是這次product的
                    txtProductName.Text = dataReader["ProductName"].ToString();
                    txtProductPrice.Text = dataReader["UnitPrice"].ToString();
                    txtUnitsInStock.Text = dataReader["UnitsInStock"].ToString();
                    txtProductDescription.Text = dataReader["Description"].ToString();
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

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                picBoxProductImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //清空所有項目
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            cbxProductBrandName.SelectedIndex = 0;
            cbxProductCategoryID.SelectedIndex = 0;
            cbxProductSubCategoryID.Items.Clear();
            picBoxProductImage.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void Update()
        {
            //商品售價
            decimal productPrice;
            if (!decimal.TryParse(txtProductPrice.Text, out productPrice))
            {
                MessageBox.Show("productPrice請輸入數字");
                return;
            }
            if (productPrice < 0)
            {
                MessageBox.Show("productPrice請輸入正整數");
                return;
            }
            //庫存量
            int unitsInStock;
            if (!int.TryParse(txtUnitsInStock.Text, out unitsInStock))
            {
                MessageBox.Show("unitsInStock請輸入數字");
                return;
            }
            if (unitsInStock < 0)
            {
                MessageBox.Show("unitsInStock請輸入正整數");
                return;
            }
            try
            {
                //Show Categories
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(@"UPDATE [dbo].[Products]
                   SET [ProductName] = @ProductName
                      ,[SubCategoryID] = @SubCategoryID
                      ,[BrandID] = @BrandID
                      ,[UnitPrice] = @UnitPrice
                      ,[UnitsInStock] = @UnitsInStock
                      ,[Description] = @Description
                 WHERE ProductID = @ProductID ", conn);
                command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                command.Parameters.AddWithValue("@SubCategoryID", Convert.ToInt32((cbxProductSubCategoryID.SelectedItem as ComboBoxItem).Value));
                command.Parameters.AddWithValue("@BrandID", Convert.ToInt32((cbxProductBrandName.SelectedItem as ComboBoxItem).Value));
                command.Parameters.AddWithValue("@UnitPrice", productPrice);
                command.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                command.Parameters.AddWithValue("@Description", txtProductDescription.Text);
                command.Parameters.AddWithValue("@ProductID", productID);
                command.ExecuteNonQuery();

                //=========================
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.picBoxProductImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();
                //=========================

                command = new SqlCommand(@"UPDATE [dbo].[ProductImagePath]
                 SET  [ProductID] =@ProductID
               ,[ProductImage] =@ProductImage
                 WHERE  ProductID = @ProductID", conn);
                command.Parameters.AddWithValue("@ProductID", productID);
                command.Parameters.AddWithValue("@ProductImage", bytes);
                //=========================
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("update successful");
            }
            catch (Exception)
            {
                MessageBox.Show("update錯誤");
            }
            this.Close();
        }

    }
}
