using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Project_IPET
{
    public partial class FrmBackLogin : Form
    {
        public FrmBackLogin()
        {
            InitializeComponent();
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

        //登入後 => 進入後台管理
        MyProjectEntities dbContext = new MyProjectEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //驗證 WHO ARE WHO
            var q = from m in this.dbContext.Members
                    where m.UserID == this.txtUserID.Text
                    select new { m.MemberID, m.UserID, m.Password, m.Salt };

            string PasswordFromDB = q.Select(m => m.Password).FirstOrDefault();
            string SaltFromDB = q.Select(m => m.Salt).FirstOrDefault();
            string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtPassword.Text + SaltFromDB, "sha1");

            //身分別判斷 => 抓取 [ RoleID ]
            var RoleID = (from m in this.dbContext.Members
                          where m.UserID == this.txtUserID.Text
                          select m.RoleID).FirstOrDefault();

            #region 判斷式
            if (Password == PasswordFromDB)
            {
                if (RoleID == 1)
                {
                    MessageBox.Show("Permission denied");
                }
                else
                {
                    string AdministratorID = q.Select(m => m.UserID).FirstOrDefault();

                    MemberUtility.AdministratorID = AdministratorID;

                    FrmBackCenter f = new FrmBackCenter();
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("invalid password");
            }
            #endregion
        }

        //點擊左下角 [ 圖標 ] => 跳轉到前台登入頁面
        private void btnForestage_Click(object sender, EventArgs e)
        {
            FrmFrontLogin f = new FrmFrontLogin();
            this.Hide();
            f.ShowDialog();
            this.Dispose();

        }
    }
}
