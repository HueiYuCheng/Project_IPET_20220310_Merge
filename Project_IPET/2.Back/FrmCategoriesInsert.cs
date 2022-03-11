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
    public partial class FrmCategoriesInsert : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Project_IPET.Properties.Settings.MyProjectConnectionString"].ToString();

        public FrmCategoriesInsert()
        {
            InitializeComponent();
        }
        //Entities
        MyProjectEntities dbContext = new MyProjectEntities();
        private void btnInsertCategories_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                #region Insert CategoryDetails into Categories DB
                SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Categories]
                 ([CategoryName]
                 ,[CategoryPicture])
                VALUES
                (@CategoryName,@CategoryPicture )", conn);
                command.Parameters.AddWithValue("@CategoryName",txtCategories.Text);
                //=========================
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.picCategoryImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();
                //=========================
                command.Parameters.AddWithValue("@CategoryPicture", bytes);
                command.ExecuteNonQuery();
                #endregion
                conn.Close();
                MessageBox.Show("新增產品成功！");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                picCategoryImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
