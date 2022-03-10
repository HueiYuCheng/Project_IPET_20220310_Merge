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
    public partial class FrmFrontLogin : Form
    {
        //FrmMemberCenter _f;
        public FrmFrontLogin()
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

        //建立帳號 => 跳轉到會員註冊頁面
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegisterMemberShip f = new FrmRegisterMemberShip();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }

        //登入後 => 進入會員中心
        MyProjectEntities dbContext = new MyProjectEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //封鎖與否
            var Banned = (from m in this.dbContext.Members
                          where m.UserID == this.txtUserID.Text
                          select m.Banned).FirstOrDefault();

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

            if (!Banned)
            {
                if (Password == PasswordFromDB)
                {
                    if (RoleID == 2)
                    {
                        MessageBox.Show("pls jump to backstage");
                    }

                    else
                    {
                        int MemberID = Convert.ToInt32(q.Select(m => m.MemberID).FirstOrDefault());
                        string UserID = q.Select(m => m.UserID).FirstOrDefault();

                        MemberUtility.MemberID = MemberID;
                        MemberUtility.UserID = UserID;
                        #region _f
                        //if (_f == null)
                        //{
                        //    MemberUtility.UserID = UserID;
                        //    _f = new FrmMemberCenter(this);
                        //    _f.LoadUserID();
                        //}
                        //this.txtUserID.Clear(); this.txtPassword.Clear();
                        //this.Hide();
                        //_f.ShowDialog();
                        #endregion

                        FrmMemberCenter f = new FrmMemberCenter();
                        this.Hide();
                        f.ShowDialog();

                        f.FormClosing += F_FormClosing;

                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("invalid password");
                }
            }
            else
            {
                MessageBox.Show("has banned");
            }
           
            #endregion
        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        //忘記密碼? => 跳轉到重設密碼介面(先身分驗證?)
        private void labForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgetPassword f = new FrmForgetPassword();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }

        //點擊左下角 [ 圖標 ] => 跳轉到後台登入頁面
        private void btnBackstage_Click(object sender, EventArgs e)
        {
            FrmBackLogin f = new FrmBackLogin();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }
    }
}
