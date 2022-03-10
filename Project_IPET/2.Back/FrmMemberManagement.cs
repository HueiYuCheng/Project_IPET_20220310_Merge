using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Project_IPET._2.Backstage
{
    public partial class FrmMemberManagement : Form
    {
        public FrmMemberManagement()
        {
            InitializeComponent();
            this.picAvatar.AllowDrop = true;
            LoadDBDataToForm();
        }

        //=========================================
        //圖片[ 拖動、瀏覽 ]事件
        #region 展開
        //圖片拖動
        private void pictureDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.picAvatar.Image = Image.FromFile(files[0]);
        }
        private void pictureDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //圖片瀏覽
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.picAvataropenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.picAvatar.Image = Image.FromFile(picAvataropenFileDialog.FileName);
            }
        }
        #endregion

        MyProjectEntities dbContext = new MyProjectEntities();
        //Load DataBase.Data To Forms
        #region 展開
        private void LoadDBDataToForm()
        {
            //Load MemberID [Data] To cmbMemberID
            var q = from m in this.dbContext.Members
                    orderby m.MemberID
                    select m.MemberID;
            this.cmbMemberID.Items.Add("All");
            foreach(var member in q)
            {
                this.cmbMemberID.Items.Add(member);
            }

            //Load MemberID [Data] To dataGridView2
            var q2 = from m in this.dbContext.Members.AsEnumerable()
                     orderby m.MemberID
                     select new
                     {
                         會員編號 = m.MemberID,
                         會員帳號 = m.UserID,
                         會員密碼 = m.Password,
                         姓名 = m.Name,
                         信箱 = m.Email,
                         手機 = m.Phone,
                         地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                         性別 = m.Gender,
                         註冊日期 = m.RegisteredDate,
                         身分別 = m.MemberRole.RoleName,
                         是否封鎖 = m.Banned
                     };
            this.bindingSource1.DataSource = q2.ToList();
            this.dataGridView2.DataSource = this.bindingSource1;

            //Load CityName [Data] To cmbCity2
            var q3 = from c in this.dbContext.Cities
                     orderby c.CityID
                     select c.CityName;
            this.cmbCity2.DataSource = q3.ToList();
            this.cmbRegion2.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load RegionName [Data] To cmbRegion2
            this.cmbRegion2.Enabled = true;
            string CityName = this.cmbCity2.Text;
            var q = from r in this.dbContext.Regions
                    where r.City.CityName == CityName
                    orderby r.RegionID
                    select r.RegionName;
            this.cmbRegion2.DataSource = q.ToList();
        }
        #endregion

        //Filter MemberID [Data] To dataGridView1
        private void cmbMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbMemberID.Text == "All")
            {
                var q = from m in this.dbContext.Members.AsEnumerable()
                        orderby m.MemberID
                        select new
                        {
                            會員編號 = m.MemberID,
                            會員帳號 = m.UserID,
                            會員密碼 = m.Password,
                            姓名 = m.Name,
                            信箱 = m.Email,
                            手機 = m.Phone,
                            地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                            性別 = m.Gender,
                            註冊日期 = m.RegisteredDate,
                            身分別 = m.MemberRole.RoleName,
                            是否封鎖 = m.Banned
                        };
                this.bindingSource1.DataSource = q.ToList();
                this.dataGridView1.DataSource = this.bindingSource1;
            }
            else
            {
                int MemberID = Convert.ToInt32(this.cmbMemberID.Text);
                var q = from m in this.dbContext.Members.AsEnumerable()
                        where m.MemberID == MemberID
                        orderby m.MemberID
                        select new
                        {
                            會員編號 = m.MemberID,
                            會員帳號 = m.UserID,
                            會員密碼 = m.Password,
                            姓名 = m.Name,
                            信箱 = m.Email,
                            手機 = m.Phone,
                            地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                            性別 = m.Gender,
                            註冊日期 = m.RegisteredDate,
                            身分別 = m.MemberRole.RoleName,
                            是否封鎖 = m.Banned
                        };
                this.bindingSource1.DataSource = q.ToList();
                this.dataGridView1.DataSource = this.bindingSource1;
            }
        }

        //Filter UserID [Data] To dataGridView1
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string UserID = this.txtUserID.Text;
            var q = from m in this.dbContext.Members.AsEnumerable()
                    where m.UserID.Contains(UserID)
                    orderby m.UserID
                    select new
                    {
                        會員編號 = m.MemberID,
                        會員帳號 = m.UserID,
                        會員密碼 = m.Password,
                        姓名 = m.Name,
                        信箱 = m.Email,
                        手機 = m.Phone,
                        地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                        性別 = m.Gender,
                        註冊日期 = m.RegisteredDate,
                        身分別 = m.MemberRole.RoleName,
                        是否封鎖 = m.Banned
                    };
            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //Method - Filter member [All] To dataGridView
        public void dataGridViewCellContent()
        {
            if (!ReferenceEquals(this.bindingSource1.Current, null))
            {
                int MemberID = ((dynamic)this.bindingSource1.Current).會員編號;

                var q = from m in dbContext.Members
                        where m.MemberID == MemberID
                        select m;

                this.txtMemberID2.Text = q.Select(m => m.MemberID).FirstOrDefault().ToString();
                this.txtUserID2.Text = q.Select(m => m.UserID).FirstOrDefault().ToString();
                this.txtPassword2.Text = q.Select(m => m.Password).FirstOrDefault().ToString();
                this.txtRegisteredDate2.Text = q.Select(m => m.RegisteredDate).FirstOrDefault().ToString();
                this.cmbCity2.Text = q.Select(m => m.Region.City.CityName).FirstOrDefault().ToString();
                this.cmbRegion2.Text = q.Select(m => m.Region.RegionName).FirstOrDefault().ToString();
                this.txtAddress2.Text = q.Select(m => m.Address).FirstOrDefault().ToString();
                this.txtPhone2.Text = q.Select(m => m.Phone).FirstOrDefault().ToString();
                this.txtEmail2.Text = q.Select(m => m.Email).FirstOrDefault().ToString();
                this.txtName2.Text = q.Select(m => m.Name).FirstOrDefault().ToString();
                this.txtGender2.Text = q.Select(m => m.Gender).FirstOrDefault().ToString();
                this.dtpBirthDate2.Value = q.Select(m => m.BirthDate).FirstOrDefault();
                try
                {
                    byte[] bytes = q.Select(m => m.Avatar).FirstOrDefault();
                    MemoryStream ms = new MemoryStream(bytes);
                    this.picAvatar.Image = Image.FromStream(ms);
                }
                catch
                {
                    this.picAvatar.Image = this.picAvatar.ErrorImage;
                }
            }

        }

        //Filter member [this] To dataGridView
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            dataGridViewCellContent();
        }

        //降冪 - memberID
        private void memberIDASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbContext.Members.AsEnumerable()
                    orderby m.MemberID ascending
                    select new
                    {
                        會員編號 = m.MemberID,
                        會員帳號 = m.UserID,
                        會員密碼 = m.Password,
                        姓名 = m.Name,
                        信箱 = m.Email,
                        手機 = m.Phone,
                        地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                        性別 = m.Gender,
                        註冊日期 = m.RegisteredDate,
                        身分別 = m.MemberRole.RoleName,
                        是否封鎖 = m.Banned
                    };
            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //升冪 - memberID
        private void memberIDDESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbContext.Members.AsEnumerable()
                    orderby m.MemberID descending
                    select new
                    {
                        會員編號 = m.MemberID,
                        會員帳號 = m.UserID,
                        會員密碼 = m.Password,
                        姓名 = m.Name,
                        信箱 = m.Email,
                        手機 = m.Phone,
                        地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                        性別 = m.Gender,
                        註冊日期 = m.RegisteredDate,
                        身分別 = m.MemberRole.RoleName,
                        是否封鎖 = m.Banned
                    };
            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //Filter Banned member
        private void bannedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = ((dynamic)this.bindingSource1.Current).會員編號;

            var q = from m in this.dbContext.Members.AsEnumerable()
                    where m.Banned
                    select new
                    {
                        會員編號 = m.MemberID,
                        會員帳號 = m.UserID,
                        會員密碼 = m.Password,
                        姓名 = m.Name,
                        信箱 = m.Email,
                        手機 = m.Phone,
                        地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                        性別 = m.Gender,
                        註冊日期 = m.RegisteredDate,
                        身分別 = m.MemberRole.RoleName,
                        是否封鎖 = m.Banned
                    };
            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //Method - Edit Banned To dataGridView
        #region 展開
        public void dataGridViewCellContentDouble()
        {
            int MemberID = ((dynamic)this.bindingSource1.Current).會員編號;

            //身分別判斷 => 抓取 [ RoleID ]
            var RoleID = (from m in this.dbContext.Members
                          where m.MemberID == MemberID
                          select m.RoleID).FirstOrDefault();

            var q = from m in this.dbContext.Members
                    where m.MemberID == MemberID
                    select m;

            if (RoleID == 2)
            {
                 DialogResult result = MessageBox.Show($"{MemberID} 為管理權限帳號","警告",MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    foreach (var b in q)
                    {
                        b.Banned = !b.Banned;
                        if (b.Banned == false)
                            MessageBox.Show("unbanned");
                        else
                            MessageBox.Show("banned");
                    }
                    this.dbContext.SaveChanges();

                    var q2 = from m in this.dbContext.Members.AsEnumerable()
                             orderby m.MemberID
                             select new
                             {
                                 會員編號 = m.MemberID,
                                 會員帳號 = m.UserID,
                                 會員密碼 = m.Password,
                                 姓名 = m.Name,
                                 信箱 = m.Email,
                                 手機 = m.Phone,
                                 地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                                 性別 = m.Gender,
                                 註冊日期 = m.RegisteredDate,
                                 身分別 = m.MemberRole.RoleName,
                                 是否封鎖 = m.Banned
                             };
                    this.bindingSource1.DataSource = q2.ToList();
                    this.dataGridView1.DataSource = this.bindingSource1;
                }
            }
            else
            {
                    foreach (var b in q)
                    {
                        b.Banned = !b.Banned;
                        if (b.Banned == false)
                            MessageBox.Show("unbanned");
                        else
                            MessageBox.Show("banned");
                    }
                this.dbContext.SaveChanges();

                var q2 = from m in this.dbContext.Members.AsEnumerable()
                         orderby m.MemberID
                         select new
                         {
                             會員編號 = m.MemberID,
                             會員帳號 = m.UserID,
                             會員密碼 = m.Password,
                             姓名 = m.Name,
                             信箱 = m.Email,
                             手機 = m.Phone,
                             地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                             性別 = m.Gender,
                             註冊日期 = m.RegisteredDate,
                             身分別 = m.MemberRole.RoleName,
                             是否封鎖 = m.Banned
                         };
                this.bindingSource1.DataSource = q2.ToList();
                this.dataGridView1.DataSource = this.bindingSource1;
            }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCellContentDouble();
        }
        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCellContentDouble();
        }
        #endregion

        //修改會員資料
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //==========加鹽部分==========
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buf = new byte[15];
            rng.GetBytes(buf);
            string salt = Convert.ToBase64String(buf);

            //==========圖片轉 byte[]==========
            MemoryStream ms = new MemoryStream();
            this.picAvatar.Image.Save(ms, ImageFormat.Png);
            byte[] bytes = ms.GetBuffer();

            //==========取得其他資料表資料==========
            var RegionID = (from r in this.dbContext.Regions
                            where r.RegionName == this.cmbRegion2.Text
                            select r.RegionID).FirstOrDefault();
            //==========Edit(Update)==========
            int MemberID = ((dynamic)this.bindingSource1.Current).會員編號;
            var members = (from m in this.dbContext.Members
                           where m.MemberID == MemberID
                           select m).FirstOrDefault();

            members.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtPassword2.Text + salt, "sha1");
            members.Salt = salt;
            members.RegionID = RegionID;
            members.Address = txtAddress2.Text;
            members.Phone = txtPhone2.Text;
            members.Email = txtEmail2.Text;
            members.Name = txtName2.Text;
            members.Gender = Convert.ToInt32(txtGender2.Text);
            members.BirthDate = this.dtpBirthDate2.Value;
            members.Avatar = bytes;

            this.dbContext.SaveChanges();
            MessageBox.Show("修改完成!");
        }

        //刪除會員資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
                int MemberID = ((dynamic)this.bindingSource1.Current).會員編號;

                DialogResult result = MessageBox.Show($"會員ID = {MemberID}, 確定要刪除嗎?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                var comment = from c in this.dbContext.Comments
                              where c.MemberID == MemberID
                              select c;
                var order = from o in this.dbContext.Orders
                            where o.MemberID == MemberID
                            select o;
                var ordertails = from od in this.dbContext.OrderDetails
                                 where od.Order.MemberID == MemberID
                                 select od;

                var member = from m in this.dbContext.Members
                             where m.MemberID == MemberID
                             select m;
               
                this.dbContext.Comments.RemoveRange(comment);
                this.dbContext.OrderDetails.RemoveRange(ordertails);
                this.dbContext.Orders.RemoveRange(order);
                this.dbContext.Members.RemoveRange(member);
                this.dbContext.SaveChanges();

                var q = from m in this.dbContext.Members.AsEnumerable()
                    orderby m.MemberID ascending
                    select new
                    {
                        會員編號 = m.MemberID,
                        會員帳號 = m.UserID,
                        會員密碼 = m.Password,
                        姓名 = m.Name,
                        信箱 = m.Email,
                        手機 = m.Phone,
                        地址 = $"{m.Region.City.CityName} {m.Region.RegionName} {m.Address}",
                        性別 = m.Gender,
                        註冊日期 = m.RegisteredDate,
                        身分別 = m.MemberRole.RoleName,
                        是否封鎖 = m.Banned
                    };
            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
            }
        }

    }
}
