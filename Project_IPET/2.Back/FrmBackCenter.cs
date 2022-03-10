using Project_IPET._2.Backstage;
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
    public partial class FrmBackCenter : Form
    {
        public FrmBackCenter()
        {
            InitializeComponent();
            btnClickAdd();
            CreateForm();
            LoadAdministratorID();
        }

        //建立Form List 存取所有Form
        List<Form> forms = new List<Form>();

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

        //進入後台管理 存取變數[AdministratorID] 
        private void LoadAdministratorID()
        {
            this.labAdministratorID.Text = MemberUtility.AdministratorID;
        }

        //側邊欄白條指向所選項目
        private void moveSidePanel(Control btn)
        {
            panLeftDivSide.Top = btn.Top;
            panLeftDivSide.Height = btn.Height;
        }
        private void moveSidePanelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            moveSidePanel(btn);
        }

        //按鈕事件
        public void btnClickAdd()
        {

            //this.btnMemberManagement.Click += btnHomePage_Click;
            this.btnMemberManagement.Click += btnMemberManagement_Click;
            this.btnProductManagement.Click += btnProductManagement_Click;
            this.btnOrderManagement.Click += btnOrderManagement_Click;
            this.btnCommentManagement.Click += btnCommentManagement_Click;
            //FrmMemberCenter FrmShoppingHistory FrmMemberProfile FrmMemberOrder FrmMemberFavorite FrmMemberAlert FrmMemberCoupon
        }

        //建立頁面
        public void CreateForm()
        {
            //首頁
            //FrmHomePage HomePage = new FrmHomePage();
            //HomePage.TopLevel = false;
            //HomePage.Dock = DockStyle.Fill;
            //HomePage.Name = "HomePage";
            //this.panelArticle.Controls.Add(HomePage);

            //會員管理
            FrmMemberManagement MemberManagement = new FrmMemberManagement();
            MemberManagement.TopLevel = false;
            MemberManagement.Dock = DockStyle.Fill;
            MemberManagement.Name = "MemberManagement";
            this.panelArticle.Controls.Add(MemberManagement);

            //商品管理
            FrmProductPage ProductManagement = new FrmProductPage();
            ProductManagement.TopLevel = false;
            ProductManagement.Dock = DockStyle.Fill;
            ProductManagement.Name = "ProductManagement";
            this.panelArticle.Controls.Add(ProductManagement);

            //訂單管理
            FrmOrder_Back OrderManagement = new FrmOrder_Back();
            OrderManagement.TopLevel = false;
            OrderManagement.Dock = DockStyle.Fill;
            OrderManagement.Name = "OrderManagement";
            this.panelArticle.Controls.Add(OrderManagement);

            //評論管理
            FrmCommentManagement CommentManagement = new FrmCommentManagement();
            CommentManagement.TopLevel = false;
            CommentManagement.Dock = DockStyle.Fill;
            CommentManagement.Name = "CommentManagement";
            this.panelArticle.Controls.Add(CommentManagement);




            //forms.Add(HomePage);
            forms.Add(MemberManagement);
            forms.Add(ProductManagement);
            forms.Add(OrderManagement);
            forms.Add(CommentManagement);


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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmBackLogin f = new FrmBackLogin();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            //OpenForm("Form的Name屬性");
            OpenForm("HomePage");
        }
        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            //OpenForm("Form的Name屬性");
            OpenForm("MemberManagement");
        }
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            //OpenForm("Form的Name屬性");
            OpenForm("ProductManagement");
        }
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            //OpenForm("Form的Name屬性");
            OpenForm("OrderManagement");
        }
        private void btnCommentManagement_Click(object sender, EventArgs e)
        {
            //OpenForm("Form的Name屬性");
            OpenForm("CommentManagement");
        }

        private void btnShutDown_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
