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
    public partial class FrmCategory : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Project_IPET.Properties.Settings.MyProjectConnectionString"].ToString();
        private int updateCategoryId = 0;

        public FrmCategory()
        {
            InitializeComponent();
            ShowCategoriesList(new CategorySearchFilter());
        }
        //Entities
        MyProjectEntities dbContext = new MyProjectEntities();
        private void ShowCategoriesList(CategorySearchFilter filter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    string sql1 = "SELECT * FROM Categories WHERE 1=1";
                    if (!string.IsNullOrWhiteSpace(filter.CategoryName)) //確認輸入的不是Null/空白鍵/""空字串
                    {
                        sql1 += " AND CategoryName LIKE '%'+@CategoryName + '%'";  //模糊比對->搜尋功能
                        command.Parameters.AddWithValue("@CategoryName", filter.CategoryName);
                    }
                    command.CommandText = sql1;
                    SqlDataReader dataReader = command.ExecuteReader();
                    dgvCategoryList.Rows.Clear();
                    while (dataReader.Read())
                    {
                        dgvCategoryList.Rows.Add(dataReader["CategoryID"], dataReader["CategoryName"], dataReader["CategoryPicture"]);
                    }
                }
            }
            catch (Exception)
            {
                //寫LOG
                MessageBox.Show("");
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCategoriesInsert categoriesInsert = new FrmCategoriesInsert();
            categoriesInsert.ShowDialog();
            ShowCategoriesList(new CategorySearchFilter());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int aa = (int)dgvCategoryList.CurrentRow.Cells[0].Value;
            if (dgvCategoryList.CurrentRow == null)
            {
                return;
            }
            var categories = (from c in this.dbContext.Categories
                              where c.CategoryID == aa
                              select c).FirstOrDefault();

            if (categories == null) return;

            MessageBox.Show("刪除成功！");
            this.dbContext.Categories.Remove(categories);
            this.dbContext.SaveChanges();

            dgvCategoryList.Rows.Clear();
            ShowCategoriesList(new CategorySearchFilter());
        }

        private void dgvCategoryList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvCategoryList.CurrentRow.Cells[0].Value == null) return;

            updateCategoryId = (int)this.dgvCategoryList.CurrentRow.Cells[0].Value;
            try
            {
                var q = from c in this.dbContext.Categories
                        where c.CategoryID == updateCategoryId
                        select c;
                foreach (var c in q)
                {
                    if(c.CategoryPicture != null)
                    {
                        MemoryStream oMemoryStream = new MemoryStream(c.CategoryPicture);
                        //設定資料流位置
                        oMemoryStream.Position = 0;  //Value目前位置設為0
                        picCategoryImage.Image = Image.FromStream(oMemoryStream);
                    }
                    
                    txtShowCategoryName.Text = c.CategoryName;
                };
            }
            catch
            {
                throw;
            }
        }

        private void dgvCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoryList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                (dgvCategoryList[e.ColumnIndex, e.RowIndex] as DataGridViewButtonCell).Value = "You Clicked Me...";
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filter = new CategorySearchFilter()
            {
                CategoryName = txtSearchCategoryName.Text
            };
            ShowCategoriesList(filter);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Show Categories
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE Categories SET CategoryName=@CategoryName  WHERE CategoryID = @CategoryID ", conn);
                command.Parameters.AddWithValue("@CategoryName", txtShowCategoryName.Text);
                command.Parameters.AddWithValue("@CategoryID", updateCategoryId);
                command.ExecuteNonQuery();
                conn.Close();
                ShowCategoriesList(new CategorySearchFilter());
                MessageBox.Show("update successful");
            }
            catch (Exception)
            {
                MessageBox.Show("update錯誤");
            }
        }
    }
}
