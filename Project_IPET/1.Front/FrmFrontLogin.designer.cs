
namespace Project_IPET
{
    partial class FrmFrontLogin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrontLogin));
            this.labTitle = new System.Windows.Forms.Label();
            this.btnBackstage = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUserID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.picNFTHeart2 = new System.Windows.Forms.PictureBox();
            this.picNFTKitty = new System.Windows.Forms.PictureBox();
            this.picNFTHeart1 = new System.Windows.Forms.PictureBox();
            this.picNFTPuppy = new System.Windows.Forms.PictureBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.labOriginal = new System.Windows.Forms.Label();
            this.labForgetPassword = new System.Windows.Forms.LinkLabel();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTKitty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTPuppy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labTitle.Location = new System.Drawing.Point(170, 22);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(256, 62);
            this.labTitle.TabIndex = 15;
            this.labTitle.Text = "IPet寵店";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBackstage
            // 
            this.btnBackstage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackstage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackstage.BackgroundImage")));
            this.btnBackstage.FlatAppearance.BorderSize = 0;
            this.btnBackstage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackstage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackstage.Location = new System.Drawing.Point(1146, 676);
            this.btnBackstage.Name = "btnBackstage";
            this.btnBackstage.Size = new System.Drawing.Size(42, 38);
            this.btnBackstage.TabIndex = 14;
            this.btnBackstage.UseVisualStyleBackColor = false;
            this.btnBackstage.Click += new System.EventHandler(this.btnBackstage_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnRegister.Location = new System.Drawing.Point(1053, 114);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 50);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "建立帳號";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnLogin.Location = new System.Drawing.Point(351, 654);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(475, 39);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labPassword
            // 
            this.labPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.labPassword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labPassword.Location = new System.Drawing.Point(354, 483);
            this.labPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(149, 38);
            this.labPassword.TabIndex = 11;
            this.labPassword.Text = "會員密碼:";
            this.labPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labUserID
            // 
            this.labUserID.BackColor = System.Drawing.Color.PowderBlue;
            this.labUserID.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labUserID.Location = new System.Drawing.Point(354, 367);
            this.labUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(149, 38);
            this.labUserID.TabIndex = 10;
            this.labUserID.Text = "會員帳號:";
            this.labUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(351, 544);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(475, 36);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Test";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserID.Location = new System.Drawing.Point(351, 428);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(475, 36);
            this.txtUserID.TabIndex = 8;
            this.txtUserID.Text = "Test";
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panHeader.Controls.Add(this.btnShutDown);
            this.panHeader.Controls.Add(this.picNFTHeart2);
            this.panHeader.Controls.Add(this.picNFTKitty);
            this.panHeader.Controls.Add(this.picNFTHeart1);
            this.panHeader.Controls.Add(this.picNFTPuppy);
            this.panHeader.Controls.Add(this.labTitle);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1200, 108);
            this.panHeader.TabIndex = 16;
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
            this.btnShutDown.Location = new System.Drawing.Point(1146, 12);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(42, 38);
            this.btnShutDown.TabIndex = 23;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // picNFTHeart2
            // 
            this.picNFTHeart2.BackColor = System.Drawing.Color.Transparent;
            this.picNFTHeart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNFTHeart2.BackgroundImage")));
            this.picNFTHeart2.Location = new System.Drawing.Point(992, 3);
            this.picNFTHeart2.Name = "picNFTHeart2";
            this.picNFTHeart2.Size = new System.Drawing.Size(27, 31);
            this.picNFTHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNFTHeart2.TabIndex = 19;
            this.picNFTHeart2.TabStop = false;
            // 
            // picNFTKitty
            // 
            this.picNFTKitty.BackColor = System.Drawing.Color.Transparent;
            this.picNFTKitty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNFTKitty.BackgroundImage")));
            this.picNFTKitty.Location = new System.Drawing.Point(1013, 3);
            this.picNFTKitty.Name = "picNFTKitty";
            this.picNFTKitty.Size = new System.Drawing.Size(103, 102);
            this.picNFTKitty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNFTKitty.TabIndex = 18;
            this.picNFTKitty.TabStop = false;
            // 
            // picNFTHeart1
            // 
            this.picNFTHeart1.BackColor = System.Drawing.Color.Transparent;
            this.picNFTHeart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNFTHeart1.BackgroundImage")));
            this.picNFTHeart1.Location = new System.Drawing.Point(137, 3);
            this.picNFTHeart1.Name = "picNFTHeart1";
            this.picNFTHeart1.Size = new System.Drawing.Size(27, 31);
            this.picNFTHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNFTHeart1.TabIndex = 17;
            this.picNFTHeart1.TabStop = false;
            // 
            // picNFTPuppy
            // 
            this.picNFTPuppy.BackColor = System.Drawing.Color.Transparent;
            this.picNFTPuppy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNFTPuppy.BackgroundImage")));
            this.picNFTPuppy.Location = new System.Drawing.Point(28, 3);
            this.picNFTPuppy.Name = "picNFTPuppy";
            this.picNFTPuppy.Size = new System.Drawing.Size(113, 102);
            this.picNFTPuppy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNFTPuppy.TabIndex = 16;
            this.picNFTPuppy.TabStop = false;
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.Transparent;
            this.picMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMain.BackgroundImage")));
            this.picMain.Location = new System.Drawing.Point(476, 178);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(286, 123);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 20;
            this.picMain.TabStop = false;
            // 
            // labOriginal
            // 
            this.labOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labOriginal.BackColor = System.Drawing.Color.Transparent;
            this.labOriginal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labOriginal.Location = new System.Drawing.Point(13, 673);
            this.labOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labOriginal.Name = "labOriginal";
            this.labOriginal.Size = new System.Drawing.Size(203, 38);
            this.labOriginal.TabIndex = 22;
            this.labOriginal.Text = "Project_IPET © 2022 ";
            this.labOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labForgetPassword
            // 
            this.labForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.labForgetPassword.Enabled = false;
            this.labForgetPassword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.labForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labForgetPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labForgetPassword.Location = new System.Drawing.Point(509, 601);
            this.labForgetPassword.Name = "labForgetPassword";
            this.labForgetPassword.Size = new System.Drawing.Size(149, 38);
            this.labForgetPassword.TabIndex = 23;
            this.labForgetPassword.TabStop = true;
            this.labForgetPassword.Text = "忘記密碼?";
            this.labForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labForgetPassword_LinkClicked);
            // 
            // FrmFrontLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.labForgetPassword);
            this.Controls.Add(this.labOriginal);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.btnBackstage);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUserID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFrontLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNFTHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTKitty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFTPuppy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnBackstage;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.PictureBox picNFTPuppy;
        private System.Windows.Forms.PictureBox picNFTHeart2;
        private System.Windows.Forms.PictureBox picNFTKitty;
        private System.Windows.Forms.PictureBox picNFTHeart1;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label labOriginal;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.LinkLabel labForgetPassword;
    }
}

