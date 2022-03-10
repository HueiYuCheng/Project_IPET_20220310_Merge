using Project_IPET._1.Forestage;
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
    public partial class FrmMemberCenter : Form
    {
        #region _f
        //FrmForestageLogin _myParent;
        //public FrmMemberCenter(FrmForestageLogin myParent)
        //{
        //    _myParent = myParent;
        //    InitializeComponent();
        //    btnClickAdd();
        //    CreateForm();
        //    LoadUserID();
        //    btnMouseMotion();
        //}
        #endregion
        public FrmMemberCenter()
        {
            InitializeComponent();
            btnClickAdd();
            CreateForm();
            LoadUserID();
            btnMouseMotion();
        }

        //建立Form List 存取所有Form
        List<Form> forms = new List<Form>();

        //========================================
        #region 視窗拖動
        //FormBorderStyle = none => 視窗拖動{1.MouseDown , 2.MouseMove , 3.MouseUp}
        bool formsMove = false;
        Point formsLocation;
        Point formsMouseOffset;

        private void forms_MouseDown(object sender,MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                formsMove = true;
                formsLocation = this.Location;
                formsMouseOffset = Control.MousePosition;
            }
        }

        private void forms_MouseMove(object sender, MouseEventArgs e)
        {
            int xOffset, yOffset;
            if(formsMove)
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

        //進入會員中心存取變數 [UserID]
        public void LoadUserID()
        {
            this.labUserID.Text = MemberUtility.UserID;
        }

        //側邊欄白條指向所選項目
        #region 展開
        private void moveSidePanel(Control btn)
        {
            panLeftDivSide.Top = btn.Top;
            panLeftDivSide.Height = btn.Height;
        }
        private void moveSidePanelClick(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            moveSidePanel(btn);
        }
        #endregion

        //滑鼠移入移出事件
        public void btnMouseMotion()
        {
            MemberUtility m = new MemberUtility();
            foreach (var n in this.Controls.OfType<Button>())
            {
                m.ChangeMouseEnterColor(n);
                m.ChangeMouseLeaveColor(n);
            }
        }

        //按鈕事件
        public void btnClickAdd()
        {
            this.btnShoppingArea.Click += BtnShoppingArea_Click;
            //==============================
            this.btnMemberCenter.Click += BtnMemberCenter_Click;
            this.btnMemberProfile.Click += BtnMemberProfile_Click;
            this.btnMemberOrder.Click += BtnMemberOrder_Click;
            this.btnShoppingHistory.Click += BtnShoppingHistory_Click;
            this.btnMemberComment.Click += BtnMyComment_Click;
        }

        //建立頁面
        public void CreateForm()
        {
            //會員專區
            //FrmMemberCenter MemberCenter = new FrmMemberCenter();
            //MemberCenter.Name = "FrmMemberCenter";
            //MemberCenter.TopLevel = false;
            //MemberCenter.Dock = DockStyle.Fill;
            //MemberCenter.BackgroundImage = Image.FromFile("BackImageBD.png");
            //this.panCenterArticle.Controls.Add(MemberCenter);

            //商品 & 購物車 頁面
            FrmShoppingArea ShoppingArea = new FrmShoppingArea();
            ShoppingArea.Name = "FrmShoppingArea";
            ShoppingArea.TopLevel = false;
            ShoppingArea.Dock = DockStyle.Fill;
            //ShoppingArea.BackgroundImage = Image.FromFile("BackImageBC.png");
            this.panCenterArticle.Controls.Add(ShoppingArea);

            //基本資料
            FrmMemberProfile MemberProfile = new FrmMemberProfile();
            MemberProfile.Name = "FrmMemberProfile";


            MemberProfile.FormClosing += MemberProfile_FormClosing;
            /***
             ***
             ***
             ***/

            MemberProfile.TopLevel = false;
            MemberProfile.Dock = DockStyle.Fill;
            //MemberProfile.BackgroundImage = Image.FromFile("BackImageOC.png");
            this.panCenterArticle.Controls.Add(MemberProfile);

            //我的訂單
            FrmOrder_Front MemberOrder = new FrmOrder_Front();
            MemberOrder.Name = "FrmMemberOrder";
            MemberOrder.TopLevel = false;
            MemberOrder.Dock = DockStyle.Fill;
            this.panCenterArticle.Controls.Add(MemberOrder);

            //已購項目
            FrmShoppingHistory ShoppingHistory = new FrmShoppingHistory();
            ShoppingHistory.Name = "FrmShoppingHistory";
            ShoppingHistory.TopLevel = false;
            ShoppingHistory.Dock = DockStyle.Fill;
            this.panCenterArticle.Controls.Add(ShoppingHistory);

            //我的評論
            FrmMemberComment MemberComment = new FrmMemberComment();
            MemberComment.Name = "FrmMemberComment";
            MemberComment.TopLevel = false;
            MemberComment.Dock = DockStyle.Fill;
            //MyComment.BackgroundImage = Image.FromFile("BackImageOC.png");
            this.panCenterArticle.Controls.Add(MemberComment);

            //forms.Add(MemberCenter);
            forms.Add(ShoppingArea);
            forms.Add(MemberProfile);
            forms.Add(MemberOrder);
            forms.Add(ShoppingHistory);
            forms.Add(MemberComment);
        }

        private void MemberProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        //頁面開啟判斷式
        public void OpenForm(string InsertName)
        {
            var q = from f in forms
                    .Where(f => f.Name == InsertName)
                    select f;

            var q1 = from f in forms
                     .Where(f => f.Name != InsertName)
                     select f;

            foreach (var item in q)
            {
                item.Show();
            }

            foreach (var form in q1)
            {
                form.Hide();
            }
        }

        private void BtnShoppingArea_Click(object sender, EventArgs e)
        {
            OpenForm("FrmShoppingArea");
        }

        private void BtnMemberCenter_Click(object sender, EventArgs e)
        {
            OpenForm("FrmMemberCenter");
        }

        private void BtnMemberProfile_Click(object sender, EventArgs e)
        {
            OpenForm("FrmMemberProfile");
        }
       
        private void BtnMemberOrder_Click(object sender, EventArgs e)
        {
            OpenForm("FrmMemberOrder");
        }

        private void BtnShoppingHistory_Click(object sender, EventArgs e)
        {
            OpenForm("FrmShoppingHistory");
        }

        private void BtnMyComment_Click(object sender, EventArgs e)
        {
            OpenForm("FrmMemberComment");
        }

        //登出
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmFrontLogin f = new FrmFrontLogin();
            this.Hide();
            f.ShowDialog();
            this.Dispose();

            //_myParent.Show();
            //this.Hide();
        }

    }
}
