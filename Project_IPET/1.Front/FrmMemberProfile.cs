using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IPET._1.Forestage
{
    public partial class FrmMemberProfile : Form
    {
        public FrmMemberProfile()
        {
            InitializeComponent();
            this.picAvatar.AllowDrop = true;
            LoadDBDataToForms();
        }

        //========================================
        //圖片[ 拖動、瀏覽 ]事件
        #region 展開
        //圖片拖動
        private void pictureDragDrop(object sender,DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.picAvatar.Image = Image.FromFile(files[0]);
        }
        private void pictureDragEnter(object sender,DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //圖片瀏覽
        private void btnBrowse_Click(object sender,EventArgs e)
        {
          
        }
        #endregion

        //Entity - 抓取資料到 Forms 控制項
        #region Load DataBase.Data To Forms
        MyProjectEntities dbContext = new MyProjectEntities();
        private void LoadDBDataToForms()
        {
            //========Load City.Data To ComboBox========
            var q = from c in this.dbContext.Cities
                    orderby c.CityID
                    select c.CityName;
            this.cmbCity.DataSource = q.ToList();
            this.cmbRegion.Enabled = false;
            //========用 [MemberID] 抓取會員資料========
            var q2 = from m in this.dbContext.Members
                    where m.MemberID == MemberUtility.MemberID
                    select new
                    {
                        m.UserID,
                        m.Password,
                        m.Avatar,
                        m.Name,
                        m.BirthDate,
                        m.Region.City.CityName,
                        m.Region.RegionName,
                        m.Address,
                        m.Phone,
                        m.Email
                    };
            if (!ReferenceEquals(this.txtUserID.Text, null))
            {
                this.txtUserID.Text = q2.Select(m => m.UserID).FirstOrDefault();
                this.txtPassword.Text = q2.Select(m => m.Password).FirstOrDefault();
                //=======================
                try
                {
                    byte[] bytes = q2.Select(m => m.Avatar).FirstOrDefault();
                    MemoryStream ms = new MemoryStream(bytes);
                    this.picAvatar.Image = Image.FromStream(ms);
                }
                catch
                {
                    this.picAvatar.Image = this.picAvatar.ErrorImage;
                }
                //=======================
                this.txtName.Text = q2.Select(m => m.Name).FirstOrDefault();
                this.dtpBirthDate.Value = q2.Select(m => m.BirthDate).FirstOrDefault();
                this.cmbCity.Text = q2.Select(m => m.CityName).FirstOrDefault();
                this.cmbRegion.Text = q2.Select(m => m.RegionName).FirstOrDefault();
                this.txtAddress.Text = q2.Select(m => m.Address).FirstOrDefault();
                this.txtPhone.Text = q2.Select(m => m.Phone).FirstOrDefault();
                this.txtEmail.Text = q2.Select(m => m.Email).FirstOrDefault();
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbRegion.Enabled = true;
            this.cmbRegion.BackColor = Color.White;
            string CityName = this.cmbCity.Text;
            var q = from r in this.dbContext.Regions
                    where r.City.CityName == CityName
                    orderby r.RegionID
                    select r.RegionName;
            this.cmbRegion.DataSource = q.ToList();
        }
        #endregion

        //Unlock - ✎解鎖編輯限制
        #region 解鎖編輯限制
        bool Nameflag = true, Phoneflag = true, Emailflag = true;

        public void ButtonIsReadOnly(object a,object b,ref bool flag)
        {
            if (flag)
            {
                ((TextBox)a).BackColor = Color.White;
                ((Label)b).ForeColor = Color.FromArgb(0, 0, 255);
                ((TextBox)a).ReadOnly = false;
            }
            else
            {
                ((TextBox)a).BackColor = Control.DefaultBackColor;
                ((Label)b).ForeColor = Color.Gray;
                ((TextBox)a).ReadOnly = true;
            }
            flag = ! flag;
        }
        private void labNameEdit_Click(object sender, EventArgs e)
        {
            ButtonIsReadOnly(this.txtName,this.labNameEdit, ref Nameflag);
        }
        private void txtPhoneEdit_Click(object sender, EventArgs e)
        {
            ButtonIsReadOnly(this.txtPhone, this.labPhoneEdit, ref Phoneflag);
        }

        private void labEmailEdit_Click(object sender, EventArgs e)
        {
            ButtonIsReadOnly(this.txtEmail, this.labEmailEdit, ref Emailflag);
        }
        #endregion

        //call 資料修改事件( MemberUtility EditMemberShip() )
        private void btnSave_Click(object sender, EventArgs e)
        {
            //先將變數存至 [ Class GetMemberProfileToTemp 裡]
            #region 展開
            GetMemberProfileToTemp.UserID = this.txtUserID.Text;
            GetMemberProfileToTemp.Password = this.txtPassword.Text;
            GetMemberProfileToTemp.Avatar = this.picAvatar.Image;
            GetMemberProfileToTemp.Name = this.txtName.Text;
            GetMemberProfileToTemp.BirthDate = this.dtpBirthDate.Value;
            GetMemberProfileToTemp.City = this.cmbCity.Text;
            GetMemberProfileToTemp.Region = this.cmbRegion.Text;
            GetMemberProfileToTemp.Address = this.txtAddress.Text;
            GetMemberProfileToTemp.Phone = this.txtPhone.Text;
            GetMemberProfileToTemp.Email = this.txtEmail.Text;
            #endregion

            MemberUtility m = new MemberUtility();
            m.EditMemberShip();
            GetMemberProfileToTemp g = new GetMemberProfileToTemp();
        }

        //會員註銷事件
        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            int MemberID = MemberUtility.MemberID;

            DialogResult result = MessageBox.Show("確定要註銷嗎?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

                MessageBox.Show("註銷成功,即將跳回登入畫面");
                //this.Close();
                //this.Dispose();

                /***Environment.Exit(Int32);
                 ***
                 ***
                 ***/

                FrmFrontLogin f = new FrmFrontLogin();
                this.Hide();
                f.ShowDialog();
                this.Dispose();
            }
        }
    }
}
