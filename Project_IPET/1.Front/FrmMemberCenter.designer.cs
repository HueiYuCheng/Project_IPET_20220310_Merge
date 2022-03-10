
namespace Project_IPET
{
    partial class FrmMemberCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberCenter));
            this.panLeftNav = new System.Windows.Forms.Panel();
            this.btnMemberComment = new System.Windows.Forms.Button();
            this.btnShoppingHistory = new System.Windows.Forms.Button();
            this.btnMemberOrder = new System.Windows.Forms.Button();
            this.btnMemberProfile = new System.Windows.Forms.Button();
            this.panLeftDivSide = new System.Windows.Forms.Panel();
            this.btnMemberCenter = new System.Windows.Forms.Button();
            this.panLeftDiv = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.labUserID = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.labMemberCenter = new System.Windows.Forms.Label();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.labHeader = new System.Windows.Forms.Label();
            this.panSection = new System.Windows.Forms.Panel();
            this.btnShoppingArea = new System.Windows.Forms.Button();
            this.panCenterArticle = new System.Windows.Forms.Panel();
            this.panLeftNav.SuspendLayout();
            this.panLeftDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.panHeader.SuspendLayout();
            this.panSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLeftNav
            // 
            this.panLeftNav.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panLeftNav.Controls.Add(this.btnMemberComment);
            this.panLeftNav.Controls.Add(this.btnShoppingHistory);
            this.panLeftNav.Controls.Add(this.btnMemberOrder);
            this.panLeftNav.Controls.Add(this.btnMemberProfile);
            this.panLeftNav.Controls.Add(this.panLeftDivSide);
            this.panLeftNav.Controls.Add(this.btnMemberCenter);
            this.panLeftNav.Controls.Add(this.panLeftDiv);
            this.panLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeftNav.Location = new System.Drawing.Point(0, 0);
            this.panLeftNav.Name = "panLeftNav";
            this.panLeftNav.Size = new System.Drawing.Size(200, 980);
            this.panLeftNav.TabIndex = 0;
            // 
            // btnMemberComment
            // 
            this.btnMemberComment.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberComment.FlatAppearance.BorderSize = 0;
            this.btnMemberComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberComment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberComment.ForeColor = System.Drawing.Color.White;
            this.btnMemberComment.Location = new System.Drawing.Point(35, 469);
            this.btnMemberComment.Name = "btnMemberComment";
            this.btnMemberComment.Size = new System.Drawing.Size(165, 38);
            this.btnMemberComment.TabIndex = 7;
            this.btnMemberComment.Text = "我的評論";
            this.btnMemberComment.UseVisualStyleBackColor = false;
            this.btnMemberComment.Visible = false;
            this.btnMemberComment.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // btnShoppingHistory
            // 
            this.btnShoppingHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnShoppingHistory.FlatAppearance.BorderSize = 0;
            this.btnShoppingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingHistory.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShoppingHistory.ForeColor = System.Drawing.Color.White;
            this.btnShoppingHistory.Location = new System.Drawing.Point(35, 399);
            this.btnShoppingHistory.Name = "btnShoppingHistory";
            this.btnShoppingHistory.Size = new System.Drawing.Size(165, 38);
            this.btnShoppingHistory.TabIndex = 6;
            this.btnShoppingHistory.Text = "已購項目";
            this.btnShoppingHistory.UseVisualStyleBackColor = false;
            this.btnShoppingHistory.Visible = false;
            this.btnShoppingHistory.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // btnMemberOrder
            // 
            this.btnMemberOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberOrder.FlatAppearance.BorderSize = 0;
            this.btnMemberOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberOrder.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberOrder.ForeColor = System.Drawing.Color.White;
            this.btnMemberOrder.Location = new System.Drawing.Point(35, 330);
            this.btnMemberOrder.Name = "btnMemberOrder";
            this.btnMemberOrder.Size = new System.Drawing.Size(165, 38);
            this.btnMemberOrder.TabIndex = 5;
            this.btnMemberOrder.Text = "我的訂單";
            this.btnMemberOrder.UseVisualStyleBackColor = false;
            this.btnMemberOrder.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // btnMemberProfile
            // 
            this.btnMemberProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberProfile.FlatAppearance.BorderSize = 0;
            this.btnMemberProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberProfile.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberProfile.ForeColor = System.Drawing.Color.White;
            this.btnMemberProfile.Location = new System.Drawing.Point(35, 263);
            this.btnMemberProfile.Name = "btnMemberProfile";
            this.btnMemberProfile.Size = new System.Drawing.Size(165, 38);
            this.btnMemberProfile.TabIndex = 4;
            this.btnMemberProfile.Text = "基本資料";
            this.btnMemberProfile.UseVisualStyleBackColor = false;
            this.btnMemberProfile.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // panLeftDivSide
            // 
            this.panLeftDivSide.BackColor = System.Drawing.Color.White;
            this.panLeftDivSide.Location = new System.Drawing.Point(3, 187);
            this.panLeftDivSide.Name = "panLeftDivSide";
            this.panLeftDivSide.Size = new System.Drawing.Size(11, 50);
            this.panLeftDivSide.TabIndex = 3;
            // 
            // btnMemberCenter
            // 
            this.btnMemberCenter.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberCenter.FlatAppearance.BorderSize = 0;
            this.btnMemberCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberCenter.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberCenter.ForeColor = System.Drawing.Color.White;
            this.btnMemberCenter.Location = new System.Drawing.Point(12, 187);
            this.btnMemberCenter.Name = "btnMemberCenter";
            this.btnMemberCenter.Size = new System.Drawing.Size(188, 47);
            this.btnMemberCenter.TabIndex = 2;
            this.btnMemberCenter.Text = "會員專區";
            this.btnMemberCenter.UseVisualStyleBackColor = false;
            this.btnMemberCenter.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // panLeftDiv
            // 
            this.panLeftDiv.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panLeftDiv.Controls.Add(this.BtnLogout);
            this.panLeftDiv.Controls.Add(this.labUserID);
            this.panLeftDiv.Controls.Add(this.picTitle);
            this.panLeftDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLeftDiv.Location = new System.Drawing.Point(0, 0);
            this.panLeftDiv.Name = "panLeftDiv";
            this.panLeftDiv.Size = new System.Drawing.Size(200, 170);
            this.panLeftDiv.TabIndex = 1;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(35, 125);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(131, 38);
            this.BtnLogout.TabIndex = 17;
            this.BtnLogout.Text = "登出";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labUserID
            // 
            this.labUserID.BackColor = System.Drawing.Color.Transparent;
            this.labUserID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUserID.ForeColor = System.Drawing.Color.Transparent;
            this.labUserID.Location = new System.Drawing.Point(6, 84);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(188, 38);
            this.labUserID.TabIndex = 16;
            this.labUserID.Text = "[UserID]";
            this.labUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(47, 3);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(100, 78);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panHeader.Controls.Add(this.labMemberCenter);
            this.panHeader.Controls.Add(this.btnShutDown);
            this.panHeader.Controls.Add(this.labHeader);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(200, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1400, 44);
            this.panHeader.TabIndex = 2;
            this.panHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forms_MouseDown);
            this.panHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.forms_MouseMove);
            this.panHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forms_MouseUp);
            // 
            // labMemberCenter
            // 
            this.labMemberCenter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labMemberCenter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMemberCenter.ForeColor = System.Drawing.Color.White;
            this.labMemberCenter.Location = new System.Drawing.Point(259, 6);
            this.labMemberCenter.Name = "labMemberCenter";
            this.labMemberCenter.Size = new System.Drawing.Size(114, 31);
            this.labMemberCenter.TabIndex = 20;
            this.labMemberCenter.Text = "會員中心";
            this.labMemberCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutDown.BackgroundImage")));
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShutDown.Location = new System.Drawing.Point(1355, 3);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(42, 38);
            this.btnShutDown.TabIndex = 24;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // labHeader
            // 
            this.labHeader.BackColor = System.Drawing.Color.Transparent;
            this.labHeader.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labHeader.Location = new System.Drawing.Point(6, 3);
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(262, 38);
            this.labHeader.TabIndex = 17;
            this.labHeader.Text = "IPet寵店 - Project_IPET";
            this.labHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSection
            // 
            this.panSection.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panSection.Controls.Add(this.btnShoppingArea);
            this.panSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSection.Location = new System.Drawing.Point(200, 44);
            this.panSection.Name = "panSection";
            this.panSection.Size = new System.Drawing.Size(1400, 61);
            this.panSection.TabIndex = 3;
            // 
            // btnShoppingArea
            // 
            this.btnShoppingArea.BackColor = System.Drawing.Color.Transparent;
            this.btnShoppingArea.FlatAppearance.BorderSize = 0;
            this.btnShoppingArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingArea.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btnShoppingArea.ForeColor = System.Drawing.Color.White;
            this.btnShoppingArea.Location = new System.Drawing.Point(38, 10);
            this.btnShoppingArea.Name = "btnShoppingArea";
            this.btnShoppingArea.Size = new System.Drawing.Size(200, 38);
            this.btnShoppingArea.TabIndex = 23;
            this.btnShoppingArea.Text = "商品 && 購物車";
            this.btnShoppingArea.UseVisualStyleBackColor = false;
            // 
            // panCenterArticle
            // 
            this.panCenterArticle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panCenterArticle.BackgroundImage")));
            this.panCenterArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panCenterArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenterArticle.Location = new System.Drawing.Point(200, 105);
            this.panCenterArticle.Name = "panCenterArticle";
            this.panCenterArticle.Size = new System.Drawing.Size(1400, 875);
            this.panCenterArticle.TabIndex = 27;
            // 
            // FrmMemberCenter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1600, 980);
            this.Controls.Add(this.panCenterArticle);
            this.Controls.Add(this.panSection);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.panLeftNav);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMemberCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMemberCenter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forms_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.forms_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forms_MouseUp);
            this.panLeftNav.ResumeLayout(false);
            this.panLeftDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLeftNav;
        private System.Windows.Forms.Panel panLeftDiv;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panSection;
        private System.Windows.Forms.Button btnMemberCenter;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Panel panLeftDivSide;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.Label labHeader;
        private System.Windows.Forms.Label labMemberCenter;
        private System.Windows.Forms.Button btnMemberProfile;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnMemberComment;
        private System.Windows.Forms.Button btnShoppingHistory;
        private System.Windows.Forms.Button btnMemberOrder;
        private System.Windows.Forms.Button btnShoppingArea;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panCenterArticle;
    }
}