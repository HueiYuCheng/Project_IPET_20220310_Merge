namespace Project_IPET
{
    partial class FrmBackCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackCenter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelArticle = new System.Windows.Forms.Panel();
            this.panHeader = new System.Windows.Forms.Panel();
            this.labMemberCenter = new System.Windows.Forms.Label();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.labHeader = new System.Windows.Forms.Label();
            this.panLeftNav = new System.Windows.Forms.Panel();
            this.lab_MemberCenter = new System.Windows.Forms.Label();
            this.btnCommentManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.panLeftDivSide = new System.Windows.Forms.Panel();
            this.panLeftDiv = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.labAdministratorID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.panLeftNav.SuspendLayout();
            this.panLeftDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelArticle);
            this.panel1.Controls.Add(this.panHeader);
            this.panel1.Controls.Add(this.panLeftNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 744);
            this.panel1.TabIndex = 5;
            // 
            // panelArticle
            // 
            this.panelArticle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelArticle.BackgroundImage")));
            this.panelArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelArticle.Location = new System.Drawing.Point(200, 44);
            this.panelArticle.Name = "panelArticle";
            this.panelArticle.Size = new System.Drawing.Size(1200, 700);
            this.panelArticle.TabIndex = 26;
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
            this.panHeader.Size = new System.Drawing.Size(1200, 44);
            this.panHeader.TabIndex = 5;
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
            this.labMemberCenter.Size = new System.Drawing.Size(159, 31);
            this.labMemberCenter.TabIndex = 20;
            this.labMemberCenter.Text = "後台管理系統";
            this.labMemberCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.PowderBlue;
            this.btnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutDown.BackgroundImage")));
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShutDown.Location = new System.Drawing.Point(1155, 3);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(42, 38);
            this.btnShutDown.TabIndex = 24;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click_1);
            // 
            // labHeader
            // 
            this.labHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.labHeader.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labHeader.Location = new System.Drawing.Point(6, 3);
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(262, 38);
            this.labHeader.TabIndex = 17;
            this.labHeader.Text = "IPet寵物店 - Project_IPET";
            this.labHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panLeftNav
            // 
            this.panLeftNav.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panLeftNav.Controls.Add(this.lab_MemberCenter);
            this.panLeftNav.Controls.Add(this.btnCommentManagement);
            this.panLeftNav.Controls.Add(this.btnOrderManagement);
            this.panLeftNav.Controls.Add(this.btnProductManagement);
            this.panLeftNav.Controls.Add(this.btnMemberManagement);
            this.panLeftNav.Controls.Add(this.panLeftDivSide);
            this.panLeftNav.Controls.Add(this.panLeftDiv);
            this.panLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeftNav.Location = new System.Drawing.Point(0, 0);
            this.panLeftNav.Name = "panLeftNav";
            this.panLeftNav.Size = new System.Drawing.Size(200, 744);
            this.panLeftNav.TabIndex = 25;
            // 
            // lab_MemberCenter
            // 
            this.lab_MemberCenter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lab_MemberCenter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_MemberCenter.ForeColor = System.Drawing.Color.Transparent;
            this.lab_MemberCenter.Location = new System.Drawing.Point(12, 182);
            this.lab_MemberCenter.Name = "lab_MemberCenter";
            this.lab_MemberCenter.Size = new System.Drawing.Size(166, 60);
            this.lab_MemberCenter.TabIndex = 17;
            this.lab_MemberCenter.Text = "後台管理系統";
            this.lab_MemberCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCommentManagement
            // 
            this.btnCommentManagement.FlatAppearance.BorderSize = 0;
            this.btnCommentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentManagement.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCommentManagement.ForeColor = System.Drawing.Color.White;
            this.btnCommentManagement.Location = new System.Drawing.Point(19, 458);
            this.btnCommentManagement.Name = "btnCommentManagement";
            this.btnCommentManagement.Size = new System.Drawing.Size(165, 38);
            this.btnCommentManagement.TabIndex = 7;
            this.btnCommentManagement.Text = "評論管理";
            this.btnCommentManagement.UseVisualStyleBackColor = true;
            this.btnCommentManagement.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.FlatAppearance.BorderSize = 0;
            this.btnOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManagement.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderManagement.ForeColor = System.Drawing.Color.White;
            this.btnOrderManagement.Location = new System.Drawing.Point(19, 394);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(165, 38);
            this.btnOrderManagement.TabIndex = 6;
            this.btnOrderManagement.Text = "訂單管理";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.FlatAppearance.BorderSize = 0;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.Location = new System.Drawing.Point(19, 324);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(165, 38);
            this.btnProductManagement.TabIndex = 5;
            this.btnProductManagement.Text = "商品管理";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // btnMemberManagement
            // 
            this.btnMemberManagement.FlatAppearance.BorderSize = 0;
            this.btnMemberManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberManagement.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberManagement.ForeColor = System.Drawing.Color.White;
            this.btnMemberManagement.Location = new System.Drawing.Point(19, 257);
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Size = new System.Drawing.Size(165, 38);
            this.btnMemberManagement.TabIndex = 4;
            this.btnMemberManagement.Text = "會員管理";
            this.btnMemberManagement.UseVisualStyleBackColor = true;
            this.btnMemberManagement.Click += new System.EventHandler(this.moveSidePanelClick);
            // 
            // panLeftDivSide
            // 
            this.panLeftDivSide.BackColor = System.Drawing.Color.White;
            this.panLeftDivSide.Location = new System.Drawing.Point(3, 257);
            this.panLeftDivSide.Name = "panLeftDivSide";
            this.panLeftDivSide.Size = new System.Drawing.Size(10, 40);
            this.panLeftDivSide.TabIndex = 3;
            // 
            // panLeftDiv
            // 
            this.panLeftDiv.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panLeftDiv.Controls.Add(this.BtnLogout);
            this.panLeftDiv.Controls.Add(this.labAdministratorID);
            this.panLeftDiv.Controls.Add(this.pictureBox1);
            this.panLeftDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLeftDiv.Location = new System.Drawing.Point(0, 0);
            this.panLeftDiv.Name = "panLeftDiv";
            this.panLeftDiv.Size = new System.Drawing.Size(200, 170);
            this.panLeftDiv.TabIndex = 1;
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(35, 116);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(131, 38);
            this.BtnLogout.TabIndex = 17;
            this.BtnLogout.Text = "登出";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labAdministratorID
            // 
            this.labAdministratorID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labAdministratorID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAdministratorID.ForeColor = System.Drawing.Color.Transparent;
            this.labAdministratorID.Location = new System.Drawing.Point(3, 84);
            this.labAdministratorID.Name = "labAdministratorID";
            this.labAdministratorID.Size = new System.Drawing.Size(194, 29);
            this.labAdministratorID.TabIndex = 16;
            this.labAdministratorID.Text = "[AdministratorID]";
            this.labAdministratorID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBackstageCenter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 744);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBackstageCenter";
            this.Text = "FrmBackstageCenter";
            this.panel1.ResumeLayout(false);
            this.panHeader.ResumeLayout(false);
            this.panLeftNav.ResumeLayout(false);
            this.panLeftDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label labMemberCenter;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label labHeader;
        private System.Windows.Forms.Panel panLeftNav;
        private System.Windows.Forms.Button btnCommentManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnMemberManagement;
        private System.Windows.Forms.Panel panLeftDivSide;
        private System.Windows.Forms.Panel panLeftDiv;
        private System.Windows.Forms.Label labAdministratorID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelArticle;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label lab_MemberCenter;
    }
}