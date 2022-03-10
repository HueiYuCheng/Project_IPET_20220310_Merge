using Project_IPET.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IPET
{
    public partial class FrmRegisterMemberShip : Form
    {
        public FrmRegisterMemberShip()
        {
            InitializeComponent();
            this.picAvatar.AllowDrop = true;
            LoadCityAndRegionToComboBox();
        }

        //========================================
        #region 視窗拖動
        //FormBorderStyle = none => 視窗拖動{1.MouseDown , 2.MouseMove , 3.MouseUp}
        bool formsMove = false;
        Point formsLocation;
        Point formsMouseOffset;

        private void forms_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formsMove = true;
                formsLocation = this.Location;
                formsMouseOffset = Control.MousePosition;
            }
        }

        private void forms_MouseMove(object sender, MouseEventArgs e)
        {
            int xOffset, yOffset;
            if (formsMove)
            {
                Point mousePoint = Control.MousePosition;
                xOffset = formsMouseOffset.X - mousePoint.X;
                yOffset = formsMouseOffset.Y - mousePoint.Y;
                this.Location = new Point(formsLocation.X - xOffset, formsLocation.Y - yOffset);
            }
        }

        private void forms_MouseUp(object sender, MouseEventArgs e)
        {
            formsMove = false;
        }
        #endregion

        //關閉功能
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //測試(填入資料)
        private void btnTest_Click(object sender, EventArgs e)
        {
            this.txtUserID.Text = "Test";
            this.txtPassword.Text = "Test";
            this.picAvatar.Image = Image.FromFile(@"../../4.Picture/NFT 狗.png");
            this.txtName.Text = "Test";
            this.rabMale.Checked = true;
            this.dtpBirthDate.Value = new DateTime(2022, 3, 6, 10, 26, 0);
            this.txtEmail.Text = "Test@Test.com";
            this.txtPhone.Text = "0123456789";
            this.cmbCity.Text = cmbCity.Items[0].ToString();
            this.cmbRegion.Text = "萬華區";
            this.txtAddress.Text = "Test";
        }

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
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(this.picAvataropenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.picAvatar.Image = Image.FromFile(picAvataropenFileDialog.FileName);
            }
        }
        #endregion

        //Entity - 抓取資料到 ComboBox
        #region Load DataBase.Data To ComboBox
        MyProjectEntities dbContext = new MyProjectEntities();
        private void LoadCityAndRegionToComboBox()
        {
            var q = from c in this.dbContext.Cities
                    orderby c.CityID
                    select c.CityName;
            this.cmbCity.DataSource = q.ToList();
            this.cmbCity.SelectedItem = null;
            if (this.cmbCity.SelectedIndex <0)
                this.cmbRegion.Enabled = false;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbRegion.Enabled = true;
            this.cmbRegion.BackColor = Color.White;
            string CityName = this.cmbCity.Text;
            //var CityID = ((MyProjectEntities)q).Cities.Select(c => c.CityID);
            var q2 = from r in this.dbContext.Regions
                     where r.City.CityName == CityName
                     orderby r.RegionID
                     select r.RegionName;
            this.cmbRegion.DataSource = q2.ToList();
        }
        #endregion

        //call 會員註冊事件( MemberUtility RegisterMemberShip() )
        #region 展開
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //先將變數存至 [ Class GetMemberProfileToTemp 裡]
            #region 展開
            GetMemberProfileToTemp.UserID = this.txtUserID.Text;
            GetMemberProfileToTemp.Password = this.txtPassword.Text;
            GetMemberProfileToTemp.Avatar = this.picAvatar.Image;
            GetMemberProfileToTemp.Name = this.txtName.Text;
            GetMemberProfileToTemp.Gender = GetMemberProfileToTemp.whichRadioButton(this.rabMale);
            GetMemberProfileToTemp.BirthDate = this.dtpBirthDate.Value;
            GetMemberProfileToTemp.Email = this.txtEmail.Text;
            GetMemberProfileToTemp.Phone = this.txtPhone.Text;
            GetMemberProfileToTemp.City = this.cmbCity.Text;
            GetMemberProfileToTemp.Region = this.cmbRegion.Text;
            GetMemberProfileToTemp.Address = this.txtAddress.Text;
            #endregion

            MemberUtility m = new MemberUtility();
            m.RegisterMemberShip();
            GetMemberProfileToTemp g = new GetMemberProfileToTemp();
            this.Close();
            this.Dispose();

            FrmFrontLogin f = new FrmFrontLogin();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }
        #endregion

        //取消 => 跳轉到登入畫面
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmFrontLogin f = new FrmFrontLogin();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }
    }

}
