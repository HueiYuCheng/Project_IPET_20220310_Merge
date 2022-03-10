
namespace Project_IPET
{
    partial class FrmRegisterMemberShip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterMemberShip));
            this.panLeftDiv = new System.Windows.Forms.Panel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.labHeader = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUserID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.rabMale = new System.Windows.Forms.RadioButton();
            this.labGender = new System.Windows.Forms.Label();
            this.rabFemale = new System.Windows.Forms.RadioButton();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.labBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labRegisterMemberShip = new System.Windows.Forms.Label();
            this.panHR1 = new System.Windows.Forms.Panel();
            this.labDescription = new System.Windows.Forms.Label();
            this.btnUserAgreement = new System.Windows.Forms.Button();
            this.ckbUserAgreement = new System.Windows.Forms.CheckBox();
            this.panHR2 = new System.Windows.Forms.Panel();
            this.labMemberProfile1 = new System.Windows.Forms.Label();
            this.labMemberProfile2 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.picAvataropenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panLeftDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panLeftDiv
            // 
            this.panLeftDiv.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panLeftDiv.Controls.Add(this.picTitle);
            this.panLeftDiv.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeftDiv.Location = new System.Drawing.Point(0, 0);
            this.panLeftDiv.Name = "panLeftDiv";
            this.panLeftDiv.Size = new System.Drawing.Size(106, 1305);
            this.panLeftDiv.TabIndex = 2;
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(3, 3);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(100, 78);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panHeader.Controls.Add(this.btnShutDown);
            this.panHeader.Controls.Add(this.labHeader);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(106, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(954, 44);
            this.panHeader.TabIndex = 3;
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
            this.btnShutDown.Location = new System.Drawing.Point(843, 3);
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
            // labPassword
            // 
            this.labPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.labPassword.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labPassword.Location = new System.Drawing.Point(170, 347);
            this.labPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(108, 25);
            this.labPassword.TabIndex = 15;
            this.labPassword.Text = "登入密碼:";
            this.labPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labUserID
            // 
            this.labUserID.BackColor = System.Drawing.Color.PowderBlue;
            this.labUserID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labUserID.Location = new System.Drawing.Point(170, 238);
            this.labUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(108, 25);
            this.labUserID.TabIndex = 14;
            this.labUserID.Text = "會員帳號:";
            this.labUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(175, 391);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(424, 30);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserID.Location = new System.Drawing.Point(175, 290);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(424, 30);
            this.txtUserID.TabIndex = 12;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnSignUp.Location = new System.Drawing.Point(420, 1218);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(270, 39);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.Text = "註冊";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // labEmail
            // 
            this.labEmail.BackColor = System.Drawing.Color.PowderBlue;
            this.labEmail.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labEmail.Location = new System.Drawing.Point(170, 831);
            this.labEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(70, 25);
            this.labEmail.TabIndex = 18;
            this.labEmail.Text = "信箱:";
            this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(175, 882);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(424, 30);
            this.txtEmail.TabIndex = 17;
            // 
            // labPhone
            // 
            this.labPhone.BackColor = System.Drawing.Color.PowderBlue;
            this.labPhone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labPhone.Location = new System.Drawing.Point(170, 936);
            this.labPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(108, 25);
            this.labPhone.TabIndex = 20;
            this.labPhone.Text = "手機號碼:";
            this.labPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(175, 984);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(424, 30);
            this.txtPhone.TabIndex = 19;
            // 
            // labAddress
            // 
            this.labAddress.BackColor = System.Drawing.Color.PowderBlue;
            this.labAddress.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labAddress.Location = new System.Drawing.Point(170, 1027);
            this.labAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(85, 25);
            this.labAddress.TabIndex = 22;
            this.labAddress.Text = "居住地:";
            this.labAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRegion
            // 
            this.cmbRegion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbRegion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(317, 1072);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(121, 28);
            this.cmbRegion.TabIndex = 23;
            // 
            // rabMale
            // 
            this.rabMale.AutoSize = true;
            this.rabMale.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rabMale.Location = new System.Drawing.Point(193, 681);
            this.rabMale.Name = "rabMale";
            this.rabMale.Size = new System.Drawing.Size(47, 28);
            this.rabMale.TabIndex = 25;
            this.rabMale.TabStop = true;
            this.rabMale.Text = "男";
            this.rabMale.UseVisualStyleBackColor = true;
            // 
            // labGender
            // 
            this.labGender.BackColor = System.Drawing.Color.PowderBlue;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labGender.Location = new System.Drawing.Point(170, 640);
            this.labGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(70, 25);
            this.labGender.TabIndex = 26;
            this.labGender.Text = "性別:";
            this.labGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rabFemale
            // 
            this.rabFemale.AutoSize = true;
            this.rabFemale.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rabFemale.Location = new System.Drawing.Point(267, 681);
            this.rabFemale.Name = "rabFemale";
            this.rabFemale.Size = new System.Drawing.Size(47, 28);
            this.rabFemale.TabIndex = 27;
            this.rabFemale.TabStop = true;
            this.rabFemale.Text = "女";
            this.rabFemale.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.SystemColors.Window;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(805, 248);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(137, 137);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 28;
            this.picAvatar.TabStop = false;
            this.picAvatar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureDragDrop);
            this.picAvatar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureDragEnter);
            // 
            // labName
            // 
            this.labName.BackColor = System.Drawing.Color.PowderBlue;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labName.Location = new System.Drawing.Point(170, 543);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(70, 25);
            this.labName.TabIndex = 29;
            this.labName.Text = "姓名:";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(175, 587);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(424, 30);
            this.txtName.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(468, 1072);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 30);
            this.txtAddress.TabIndex = 32;
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(175, 1072);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 28);
            this.cmbCity.TabIndex = 33;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // labBirthDate
            // 
            this.labBirthDate.BackColor = System.Drawing.Color.PowderBlue;
            this.labBirthDate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labBirthDate.Location = new System.Drawing.Point(170, 724);
            this.labBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBirthDate.Name = "labBirthDate";
            this.labBirthDate.Size = new System.Drawing.Size(70, 25);
            this.labBirthDate.TabIndex = 34;
            this.labBirthDate.Text = "生日:";
            this.labBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(175, 777);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(139, 22);
            this.dtpBirthDate.TabIndex = 35;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnBrowse.Location = new System.Drawing.Point(805, 396);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 34);
            this.btnBrowse.TabIndex = 37;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labRegisterMemberShip
            // 
            this.labRegisterMemberShip.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labRegisterMemberShip.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold);
            this.labRegisterMemberShip.ForeColor = System.Drawing.Color.White;
            this.labRegisterMemberShip.Location = new System.Drawing.Point(167, 65);
            this.labRegisterMemberShip.Name = "labRegisterMemberShip";
            this.labRegisterMemberShip.Size = new System.Drawing.Size(174, 48);
            this.labRegisterMemberShip.TabIndex = 38;
            this.labRegisterMemberShip.Text = "會員註冊";
            this.labRegisterMemberShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panHR1
            // 
            this.panHR1.BackColor = System.Drawing.Color.PowderBlue;
            this.panHR1.Location = new System.Drawing.Point(161, 127);
            this.panHR1.Name = "panHR1";
            this.panHR1.Size = new System.Drawing.Size(781, 3);
            this.panHR1.TabIndex = 39;
            // 
            // labDescription
            // 
            this.labDescription.BackColor = System.Drawing.Color.Transparent;
            this.labDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.labDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.labDescription.Location = new System.Drawing.Point(171, 133);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(373, 26);
            this.labDescription.TabIndex = 40;
            this.labDescription.Text = "請正確填寫以下資料，過程只需要１分鐘時間。";
            this.labDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUserAgreement
            // 
            this.btnUserAgreement.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUserAgreement.FlatAppearance.BorderSize = 0;
            this.btnUserAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAgreement.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUserAgreement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnUserAgreement.Location = new System.Drawing.Point(429, 1132);
            this.btnUserAgreement.Name = "btnUserAgreement";
            this.btnUserAgreement.Size = new System.Drawing.Size(170, 44);
            this.btnUserAgreement.TabIndex = 41;
            this.btnUserAgreement.Text = "使用規約\r\n請詳閱後勾選同意";
            this.btnUserAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAgreement.UseVisualStyleBackColor = false;
            // 
            // ckbUserAgreement
            // 
            this.ckbUserAgreement.AutoSize = true;
            this.ckbUserAgreement.BackColor = System.Drawing.Color.Transparent;
            this.ckbUserAgreement.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbUserAgreement.Location = new System.Drawing.Point(175, 1155);
            this.ckbUserAgreement.Name = "ckbUserAgreement";
            this.ckbUserAgreement.Size = new System.Drawing.Size(248, 21);
            this.ckbUserAgreement.TabIndex = 42;
            this.ckbUserAgreement.Text = "我同意遵守使用規約和隱私權政策說明";
            this.ckbUserAgreement.UseVisualStyleBackColor = false;
            // 
            // panHR2
            // 
            this.panHR2.BackColor = System.Drawing.Color.PowderBlue;
            this.panHR2.Location = new System.Drawing.Point(161, 454);
            this.panHR2.Name = "panHR2";
            this.panHR2.Size = new System.Drawing.Size(781, 3);
            this.panHR2.TabIndex = 40;
            // 
            // labMemberProfile1
            // 
            this.labMemberProfile1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labMemberProfile1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.labMemberProfile1.ForeColor = System.Drawing.Color.White;
            this.labMemberProfile1.Location = new System.Drawing.Point(169, 183);
            this.labMemberProfile1.Name = "labMemberProfile1";
            this.labMemberProfile1.Size = new System.Drawing.Size(135, 32);
            this.labMemberProfile1.TabIndex = 43;
            this.labMemberProfile1.Text = "1.帳號資料";
            this.labMemberProfile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labMemberProfile2
            // 
            this.labMemberProfile2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labMemberProfile2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.labMemberProfile2.ForeColor = System.Drawing.Color.White;
            this.labMemberProfile2.Location = new System.Drawing.Point(169, 484);
            this.labMemberProfile2.Name = "labMemberProfile2";
            this.labMemberProfile2.Size = new System.Drawing.Size(157, 32);
            this.labMemberProfile2.TabIndex = 44;
            this.labMemberProfile2.Text = "2.聯絡人資料";
            this.labMemberProfile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnTest.Location = new System.Drawing.Point(876, 65);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(66, 34);
            this.btnTest.TabIndex = 45;
            this.btnTest.Text = "測試";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // picAvataropenFileDialog
            // 
            this.picAvataropenFileDialog.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(420, 1266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(270, 39);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmRegisterMemberShip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1077, 1000);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.labMemberProfile2);
            this.Controls.Add(this.labMemberProfile1);
            this.Controls.Add(this.panHR2);
            this.Controls.Add(this.ckbUserAgreement);
            this.Controls.Add(this.btnUserAgreement);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.panHR1);
            this.Controls.Add(this.labRegisterMemberShip);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.labBirthDate);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.rabFemale);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.rabMale);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUserID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.panLeftDiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegisterMemberShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterMemberShip";
            this.panLeftDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.panHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panLeftDiv;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label labHeader;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.RadioButton rabMale;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.RadioButton rabFemale;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label labBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label labRegisterMemberShip;
        private System.Windows.Forms.Panel panHR1;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Button btnUserAgreement;
        private System.Windows.Forms.CheckBox ckbUserAgreement;
        private System.Windows.Forms.Panel panHR2;
        private System.Windows.Forms.Label labMemberProfile1;
        private System.Windows.Forms.Label labMemberProfile2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.OpenFileDialog picAvataropenFileDialog;
        private System.Windows.Forms.Button btnCancel;
    }
}