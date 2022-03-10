
namespace Project_IPET
{
    partial class FrmBackLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackLogin));
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.panSection = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.panFooter = new System.Windows.Forms.Panel();
            this.labOriginal = new System.Windows.Forms.Label();
            this.labAbout = new System.Windows.Forms.Label();
            this.panArticle = new System.Windows.Forms.Panel();
            this.btnForestage = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.labUserID = new System.Windows.Forms.Label();
            this.picSquare = new System.Windows.Forms.PictureBox();
            this.panHeader.SuspendLayout();
            this.panSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.panFooter.SuspendLayout();
            this.panArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panHeader.BackgroundImage")));
            this.panHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panHeader.Controls.Add(this.btnShutDown);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1200, 38);
            this.panHeader.TabIndex = 0;
            this.panHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forms_MouseDown);
            this.panHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.forms_MouseMove);
            this.panHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forms_MouseUp);
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutDown.BackgroundImage")));
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShutDown.Location = new System.Drawing.Point(1146, 0);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(42, 38);
            this.btnShutDown.TabIndex = 24;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // panSection
            // 
            this.panSection.BackColor = System.Drawing.Color.White;
            this.panSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panSection.Controls.Add(this.labTitle);
            this.panSection.Controls.Add(this.picMain);
            this.panSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSection.Location = new System.Drawing.Point(0, 38);
            this.panSection.Name = "panSection";
            this.panSection.Size = new System.Drawing.Size(1200, 207);
            this.panSection.TabIndex = 1;
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labTitle.Location = new System.Drawing.Point(384, 141);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(469, 62);
            this.labTitle.TabIndex = 16;
            this.labTitle.Text = "IPet寵物店後台管理系統";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.Transparent;
            this.picMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMain.BackgroundImage")));
            this.picMain.Location = new System.Drawing.Point(473, 15);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(286, 123);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 22;
            this.picMain.TabStop = false;
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panFooter.BackgroundImage")));
            this.panFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panFooter.Controls.Add(this.labOriginal);
            this.panFooter.Controls.Add(this.labAbout);
            this.panFooter.Location = new System.Drawing.Point(0, 900);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(1200, 124);
            this.panFooter.TabIndex = 2;
            // 
            // labOriginal
            // 
            this.labOriginal.BackColor = System.Drawing.Color.Transparent;
            this.labOriginal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOriginal.ForeColor = System.Drawing.Color.White;
            this.labOriginal.Location = new System.Drawing.Point(517, 78);
            this.labOriginal.Name = "labOriginal";
            this.labOriginal.Size = new System.Drawing.Size(217, 37);
            this.labOriginal.TabIndex = 1;
            this.labOriginal.Text = "Project_IPET © 2022 ";
            // 
            // labAbout
            // 
            this.labAbout.BackColor = System.Drawing.Color.Transparent;
            this.labAbout.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAbout.ForeColor = System.Drawing.Color.White;
            this.labAbout.Location = new System.Drawing.Point(483, 30);
            this.labAbout.Name = "labAbout";
            this.labAbout.Size = new System.Drawing.Size(292, 37);
            this.labAbout.TabIndex = 0;
            this.labAbout.Text = "關於我們   /   隱私權政策";
            // 
            // panArticle
            // 
            this.panArticle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panArticle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panArticle.BackgroundImage")));
            this.panArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panArticle.Controls.Add(this.btnForestage);
            this.panArticle.Controls.Add(this.btnLogin);
            this.panArticle.Controls.Add(this.txtPassword);
            this.panArticle.Controls.Add(this.labPassword);
            this.panArticle.Controls.Add(this.txtUserID);
            this.panArticle.Controls.Add(this.labUserID);
            this.panArticle.Controls.Add(this.picSquare);
            this.panArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panArticle.Location = new System.Drawing.Point(0, 245);
            this.panArticle.Name = "panArticle";
            this.panArticle.Size = new System.Drawing.Size(1200, 661);
            this.panArticle.TabIndex = 3;
            // 
            // btnForestage
            // 
            this.btnForestage.BackColor = System.Drawing.Color.Transparent;
            this.btnForestage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForestage.BackgroundImage")));
            this.btnForestage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForestage.FlatAppearance.BorderSize = 0;
            this.btnForestage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForestage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForestage.Location = new System.Drawing.Point(1155, 620);
            this.btnForestage.Name = "btnForestage";
            this.btnForestage.Size = new System.Drawing.Size(42, 38);
            this.btnForestage.TabIndex = 35;
            this.btnForestage.UseVisualStyleBackColor = false;
            this.btnForestage.Click += new System.EventHandler(this.btnForestage_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(577, 550);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 40);
            this.btnLogin.TabIndex = 31;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(384, 400);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(475, 36);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Text = "Admin";
            // 
            // labPassword
            // 
            this.labPassword.BackColor = System.Drawing.Color.Transparent;
            this.labPassword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPassword.ForeColor = System.Drawing.Color.White;
            this.labPassword.Image = ((System.Drawing.Image)(resources.GetObject("labPassword.Image")));
            this.labPassword.Location = new System.Drawing.Point(375, 289);
            this.labPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(172, 38);
            this.labPassword.TabIndex = 29;
            this.labPassword.Text = "管理者密碼:";
            this.labPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserID.Location = new System.Drawing.Point(381, 212);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(475, 36);
            this.txtUserID.TabIndex = 28;
            this.txtUserID.Text = "Admin";
            // 
            // labUserID
            // 
            this.labUserID.BackColor = System.Drawing.Color.Transparent;
            this.labUserID.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUserID.ForeColor = System.Drawing.Color.White;
            this.labUserID.Image = ((System.Drawing.Image)(resources.GetObject("labUserID.Image")));
            this.labUserID.Location = new System.Drawing.Point(375, 121);
            this.labUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(172, 38);
            this.labUserID.TabIndex = 27;
            this.labUserID.Text = "管理者帳號:";
            this.labUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSquare
            // 
            this.picSquare.BackColor = System.Drawing.Color.Transparent;
            this.picSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSquare.BackgroundImage")));
            this.picSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSquare.Location = new System.Drawing.Point(331, 23);
            this.picSquare.Name = "picSquare";
            this.picSquare.Size = new System.Drawing.Size(569, 614);
            this.picSquare.TabIndex = 0;
            this.picSquare.TabStop = false;
            // 
            // FrmBackLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panArticle);
            this.Controls.Add(this.panFooter);
            this.Controls.Add(this.panSection);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBackLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panHeader.ResumeLayout(false);
            this.panSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panArticle.ResumeLayout(false);
            this.panArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panSection;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.Label labAbout;
        private System.Windows.Forms.Label labOriginal;
        private System.Windows.Forms.Panel panArticle;
        private System.Windows.Forms.PictureBox picSquare;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForestage;
    }
}