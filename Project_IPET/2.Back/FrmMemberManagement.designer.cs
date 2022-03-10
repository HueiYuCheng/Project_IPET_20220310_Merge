
namespace Project_IPET._2.Backstage
{
    partial class FrmMemberManagement
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
            this.components = new System.ComponentModel.Container();
            this.labTitle = new System.Windows.Forms.Label();
            this.grpRange1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbMemberID = new System.Windows.Forms.ComboBox();
            this.labUserID = new System.Windows.Forms.Label();
            this.labMemberID = new System.Windows.Forms.Label();
            this.grpRange2 = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate2 = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.labEmail2 = new System.Windows.Forms.Label();
            this.cmbRegion2 = new System.Windows.Forms.ComboBox();
            this.cmbCity2 = new System.Windows.Forms.ComboBox();
            this.txtRegisteredDate2 = new System.Windows.Forms.TextBox();
            this.labRegion2 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtGender2 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUserID2 = new System.Windows.Forms.TextBox();
            this.txtMemberID2 = new System.Windows.Forms.TextBox();
            this.labBirthDate2 = new System.Windows.Forms.Label();
            this.labGender2 = new System.Windows.Forms.Label();
            this.labName2 = new System.Windows.Forms.Label();
            this.labPhone2 = new System.Windows.Forms.Label();
            this.labAddress2 = new System.Windows.Forms.Label();
            this.labCity2 = new System.Windows.Forms.Label();
            this.labRegisteredDate2 = new System.Windows.Forms.Label();
            this.labPassword2 = new System.Windows.Forms.Label();
            this.labUserID2 = new System.Windows.Forms.Label();
            this.labMemberID2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpRange3 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.picAvataropenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memberIDASCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberIDDESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRange1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpRange2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpRange3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold);
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(28, 32);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(174, 48);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "會員管理";
            // 
            // grpRange1
            // 
            this.grpRange1.Controls.Add(this.btnSearch);
            this.grpRange1.Controls.Add(this.txtUserID);
            this.grpRange1.Controls.Add(this.dataGridView1);
            this.grpRange1.Controls.Add(this.cmbMemberID);
            this.grpRange1.Controls.Add(this.labUserID);
            this.grpRange1.Controls.Add(this.labMemberID);
            this.grpRange1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpRange1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.grpRange1.Location = new System.Drawing.Point(36, 104);
            this.grpRange1.Name = "grpRange1";
            this.grpRange1.Size = new System.Drawing.Size(566, 441);
            this.grpRange1.TabIndex = 1;
            this.grpRange1.TabStop = false;
            this.grpRange1.Text = "MemberID、UserID查詢";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnSearch.Location = new System.Drawing.Point(440, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 29);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(334, 62);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 29);
            this.txtUserID.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(19, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 313);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // cmbMemberID
            // 
            this.cmbMemberID.FormattingEnabled = true;
            this.cmbMemberID.Location = new System.Drawing.Point(113, 62);
            this.cmbMemberID.Name = "cmbMemberID";
            this.cmbMemberID.Size = new System.Drawing.Size(121, 29);
            this.cmbMemberID.TabIndex = 3;
            this.cmbMemberID.SelectedIndexChanged += new System.EventHandler(this.cmbMemberID_SelectedIndexChanged);
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.BackColor = System.Drawing.Color.PowderBlue;
            this.labUserID.Location = new System.Drawing.Point(266, 65);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(62, 21);
            this.labUserID.TabIndex = 2;
            this.labUserID.Text = "UserID";
            // 
            // labMemberID
            // 
            this.labMemberID.AutoSize = true;
            this.labMemberID.BackColor = System.Drawing.Color.PowderBlue;
            this.labMemberID.Location = new System.Drawing.Point(15, 65);
            this.labMemberID.Name = "labMemberID";
            this.labMemberID.Size = new System.Drawing.Size(92, 21);
            this.labMemberID.TabIndex = 1;
            this.labMemberID.Text = "MemberID";
            // 
            // grpRange2
            // 
            this.grpRange2.Controls.Add(this.dtpBirthDate2);
            this.grpRange2.Controls.Add(this.btnEdit);
            this.grpRange2.Controls.Add(this.btnDelete);
            this.grpRange2.Controls.Add(this.btnBrowse);
            this.grpRange2.Controls.Add(this.txtEmail2);
            this.grpRange2.Controls.Add(this.labEmail2);
            this.grpRange2.Controls.Add(this.cmbRegion2);
            this.grpRange2.Controls.Add(this.cmbCity2);
            this.grpRange2.Controls.Add(this.txtRegisteredDate2);
            this.grpRange2.Controls.Add(this.labRegion2);
            this.grpRange2.Controls.Add(this.picAvatar);
            this.grpRange2.Controls.Add(this.txtGender2);
            this.grpRange2.Controls.Add(this.txtName2);
            this.grpRange2.Controls.Add(this.txtPhone2);
            this.grpRange2.Controls.Add(this.txtAddress2);
            this.grpRange2.Controls.Add(this.txtPassword2);
            this.grpRange2.Controls.Add(this.txtUserID2);
            this.grpRange2.Controls.Add(this.txtMemberID2);
            this.grpRange2.Controls.Add(this.labBirthDate2);
            this.grpRange2.Controls.Add(this.labGender2);
            this.grpRange2.Controls.Add(this.labName2);
            this.grpRange2.Controls.Add(this.labPhone2);
            this.grpRange2.Controls.Add(this.labAddress2);
            this.grpRange2.Controls.Add(this.labCity2);
            this.grpRange2.Controls.Add(this.labRegisteredDate2);
            this.grpRange2.Controls.Add(this.labPassword2);
            this.grpRange2.Controls.Add(this.labUserID2);
            this.grpRange2.Controls.Add(this.labMemberID2);
            this.grpRange2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpRange2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.grpRange2.Location = new System.Drawing.Point(620, 104);
            this.grpRange2.Name = "grpRange2";
            this.grpRange2.Size = new System.Drawing.Size(613, 441);
            this.grpRange2.TabIndex = 2;
            this.grpRange2.TabStop = false;
            this.grpRange2.Text = "會員資料修改/刪除";
            // 
            // dtpBirthDate2
            // 
            this.dtpBirthDate2.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpBirthDate2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpBirthDate2.Location = new System.Drawing.Point(434, 99);
            this.dtpBirthDate2.Name = "dtpBirthDate2";
            this.dtpBirthDate2.Size = new System.Drawing.Size(163, 25);
            this.dtpBirthDate2.TabIndex = 42;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnEdit.Location = new System.Drawing.Point(366, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 36);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnDelete.Location = new System.Drawing.Point(457, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 36);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnBrowse.Location = new System.Drawing.Point(367, 310);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 36);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(139, 317);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(158, 29);
            this.txtEmail2.TabIndex = 31;
            // 
            // labEmail2
            // 
            this.labEmail2.AutoSize = true;
            this.labEmail2.BackColor = System.Drawing.Color.PowderBlue;
            this.labEmail2.Location = new System.Drawing.Point(82, 320);
            this.labEmail2.Name = "labEmail2";
            this.labEmail2.Size = new System.Drawing.Size(51, 21);
            this.labEmail2.TabIndex = 30;
            this.labEmail2.Text = "Email";
            // 
            // cmbRegion2
            // 
            this.cmbRegion2.FormattingEnabled = true;
            this.cmbRegion2.Location = new System.Drawing.Point(139, 204);
            this.cmbRegion2.Name = "cmbRegion2";
            this.cmbRegion2.Size = new System.Drawing.Size(158, 29);
            this.cmbRegion2.TabIndex = 29;
            // 
            // cmbCity2
            // 
            this.cmbCity2.FormattingEnabled = true;
            this.cmbCity2.Location = new System.Drawing.Point(139, 169);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.Size = new System.Drawing.Size(158, 29);
            this.cmbCity2.TabIndex = 28;
            this.cmbCity2.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtRegisteredDate2
            // 
            this.txtRegisteredDate2.Enabled = false;
            this.txtRegisteredDate2.Location = new System.Drawing.Point(139, 134);
            this.txtRegisteredDate2.Name = "txtRegisteredDate2";
            this.txtRegisteredDate2.Size = new System.Drawing.Size(158, 29);
            this.txtRegisteredDate2.TabIndex = 27;
            // 
            // labRegion2
            // 
            this.labRegion2.AutoSize = true;
            this.labRegion2.BackColor = System.Drawing.Color.PowderBlue;
            this.labRegion2.Location = new System.Drawing.Point(69, 207);
            this.labRegion2.Name = "labRegion2";
            this.labRegion2.Size = new System.Drawing.Size(64, 21);
            this.labRegion2.TabIndex = 25;
            this.labRegion2.Text = "Region";
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(366, 146);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(169, 152);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 21;
            this.picAvatar.TabStop = false;
            this.picAvatar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureDragDrop);
            this.picAvatar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureDragEnter);
            // 
            // txtGender2
            // 
            this.txtGender2.Location = new System.Drawing.Point(434, 64);
            this.txtGender2.Name = "txtGender2";
            this.txtGender2.Size = new System.Drawing.Size(163, 29);
            this.txtGender2.TabIndex = 18;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(434, 29);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(163, 29);
            this.txtName2.TabIndex = 17;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(139, 274);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(158, 29);
            this.txtPhone2.TabIndex = 16;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(139, 239);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(158, 29);
            this.txtAddress2.TabIndex = 15;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(139, 99);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(158, 29);
            this.txtPassword2.TabIndex = 13;
            // 
            // txtUserID2
            // 
            this.txtUserID2.Enabled = false;
            this.txtUserID2.Location = new System.Drawing.Point(139, 64);
            this.txtUserID2.Name = "txtUserID2";
            this.txtUserID2.Size = new System.Drawing.Size(158, 29);
            this.txtUserID2.TabIndex = 12;
            // 
            // txtMemberID2
            // 
            this.txtMemberID2.Enabled = false;
            this.txtMemberID2.Location = new System.Drawing.Point(139, 29);
            this.txtMemberID2.Name = "txtMemberID2";
            this.txtMemberID2.Size = new System.Drawing.Size(158, 29);
            this.txtMemberID2.TabIndex = 11;
            // 
            // labBirthDate2
            // 
            this.labBirthDate2.AutoSize = true;
            this.labBirthDate2.BackColor = System.Drawing.Color.PowderBlue;
            this.labBirthDate2.Location = new System.Drawing.Point(346, 102);
            this.labBirthDate2.Name = "labBirthDate2";
            this.labBirthDate2.Size = new System.Drawing.Size(82, 21);
            this.labBirthDate2.TabIndex = 10;
            this.labBirthDate2.Text = "BirthDate";
            // 
            // labGender2
            // 
            this.labGender2.AutoSize = true;
            this.labGender2.BackColor = System.Drawing.Color.PowderBlue;
            this.labGender2.Location = new System.Drawing.Point(362, 67);
            this.labGender2.Name = "labGender2";
            this.labGender2.Size = new System.Drawing.Size(66, 21);
            this.labGender2.TabIndex = 9;
            this.labGender2.Text = "Gender";
            // 
            // labName2
            // 
            this.labName2.AutoSize = true;
            this.labName2.BackColor = System.Drawing.Color.PowderBlue;
            this.labName2.Location = new System.Drawing.Point(372, 32);
            this.labName2.Name = "labName2";
            this.labName2.Size = new System.Drawing.Size(56, 21);
            this.labName2.TabIndex = 8;
            this.labName2.Text = "Name";
            // 
            // labPhone2
            // 
            this.labPhone2.AutoSize = true;
            this.labPhone2.BackColor = System.Drawing.Color.PowderBlue;
            this.labPhone2.Location = new System.Drawing.Point(74, 277);
            this.labPhone2.Name = "labPhone2";
            this.labPhone2.Size = new System.Drawing.Size(59, 21);
            this.labPhone2.TabIndex = 7;
            this.labPhone2.Text = "Phone";
            // 
            // labAddress2
            // 
            this.labAddress2.AutoSize = true;
            this.labAddress2.BackColor = System.Drawing.Color.PowderBlue;
            this.labAddress2.Location = new System.Drawing.Point(60, 242);
            this.labAddress2.Name = "labAddress2";
            this.labAddress2.Size = new System.Drawing.Size(73, 21);
            this.labAddress2.TabIndex = 6;
            this.labAddress2.Text = "Address";
            // 
            // labCity2
            // 
            this.labCity2.AutoSize = true;
            this.labCity2.BackColor = System.Drawing.Color.PowderBlue;
            this.labCity2.Location = new System.Drawing.Point(93, 172);
            this.labCity2.Name = "labCity2";
            this.labCity2.Size = new System.Drawing.Size(40, 21);
            this.labCity2.TabIndex = 5;
            this.labCity2.Text = "City";
            // 
            // labRegisteredDate2
            // 
            this.labRegisteredDate2.AutoSize = true;
            this.labRegisteredDate2.BackColor = System.Drawing.Color.PowderBlue;
            this.labRegisteredDate2.Location = new System.Drawing.Point(5, 137);
            this.labRegisteredDate2.Name = "labRegisteredDate2";
            this.labRegisteredDate2.Size = new System.Drawing.Size(128, 21);
            this.labRegisteredDate2.TabIndex = 4;
            this.labRegisteredDate2.Text = "RegisteredDate";
            // 
            // labPassword2
            // 
            this.labPassword2.AutoSize = true;
            this.labPassword2.BackColor = System.Drawing.Color.PowderBlue;
            this.labPassword2.Location = new System.Drawing.Point(49, 102);
            this.labPassword2.Name = "labPassword2";
            this.labPassword2.Size = new System.Drawing.Size(84, 21);
            this.labPassword2.TabIndex = 3;
            this.labPassword2.Text = "Password";
            // 
            // labUserID2
            // 
            this.labUserID2.AutoSize = true;
            this.labUserID2.BackColor = System.Drawing.Color.PowderBlue;
            this.labUserID2.Location = new System.Drawing.Point(71, 67);
            this.labUserID2.Name = "labUserID2";
            this.labUserID2.Size = new System.Drawing.Size(62, 21);
            this.labUserID2.TabIndex = 2;
            this.labUserID2.Text = "UserID";
            // 
            // labMemberID2
            // 
            this.labMemberID2.AutoSize = true;
            this.labMemberID2.BackColor = System.Drawing.Color.PowderBlue;
            this.labMemberID2.Location = new System.Drawing.Point(41, 32);
            this.labMemberID2.Name = "labMemberID2";
            this.labMemberID2.Size = new System.Drawing.Size(92, 21);
            this.labMemberID2.TabIndex = 1;
            this.labMemberID2.Text = "MemberID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(42, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(991, 382);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // grpRange3
            // 
            this.grpRange3.BackColor = System.Drawing.SystemColors.Control;
            this.grpRange3.Controls.Add(this.dataGridView2);
            this.grpRange3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpRange3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.grpRange3.Location = new System.Drawing.Point(36, 566);
            this.grpRange3.Name = "grpRange3";
            this.grpRange3.Size = new System.Drawing.Size(1074, 422);
            this.grpRange3.TabIndex = 8;
            this.grpRange3.TabStop = false;
            this.grpRange3.Text = "全部會員資料檢視";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // picAvataropenFileDialog
            // 
            this.picAvataropenFileDialog.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberIDASCToolStripMenuItem,
            this.memberIDDESCToolStripMenuItem,
            this.bannedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 70);
            // 
            // memberIDASCToolStripMenuItem
            // 
            this.memberIDASCToolStripMenuItem.Name = "memberIDASCToolStripMenuItem";
            this.memberIDASCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memberIDASCToolStripMenuItem.Text = "MemberID ASC";
            this.memberIDASCToolStripMenuItem.Click += new System.EventHandler(this.memberIDASCToolStripMenuItem_Click);
            // 
            // memberIDDESCToolStripMenuItem
            // 
            this.memberIDDESCToolStripMenuItem.Name = "memberIDDESCToolStripMenuItem";
            this.memberIDDESCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memberIDDESCToolStripMenuItem.Text = "MemberID DESC";
            this.memberIDDESCToolStripMenuItem.Click += new System.EventHandler(this.memberIDDESCToolStripMenuItem_Click);
            // 
            // bannedToolStripMenuItem
            // 
            this.bannedToolStripMenuItem.Name = "bannedToolStripMenuItem";
            this.bannedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bannedToolStripMenuItem.Text = "Banned";
            this.bannedToolStripMenuItem.Click += new System.EventHandler(this.bannedToolStripMenuItem_Click);
            // 
            // FrmMemberManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1250, 1000);
            this.Controls.Add(this.grpRange3);
            this.Controls.Add(this.grpRange2);
            this.Controls.Add(this.grpRange1);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMemberManagement";
            this.grpRange1.ResumeLayout(false);
            this.grpRange1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpRange2.ResumeLayout(false);
            this.grpRange2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpRange3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.GroupBox grpRange1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMemberID;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.Label labMemberID;
        private System.Windows.Forms.GroupBox grpRange2;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtGender2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtUserID2;
        private System.Windows.Forms.TextBox txtMemberID2;
        private System.Windows.Forms.Label labBirthDate2;
        private System.Windows.Forms.Label labGender2;
        private System.Windows.Forms.Label labName2;
        private System.Windows.Forms.Label labPhone2;
        private System.Windows.Forms.Label labAddress2;
        private System.Windows.Forms.Label labCity2;
        private System.Windows.Forms.Label labRegisteredDate2;
        private System.Windows.Forms.Label labPassword2;
        private System.Windows.Forms.Label labUserID2;
        private System.Windows.Forms.Label labMemberID2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grpRange3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label labEmail2;
        private System.Windows.Forms.ComboBox cmbRegion2;
        private System.Windows.Forms.ComboBox cmbCity2;
        private System.Windows.Forms.TextBox txtRegisteredDate2;
        private System.Windows.Forms.Label labRegion2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog picAvataropenFileDialog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DateTimePicker dtpBirthDate2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberIDASCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberIDDESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannedToolStripMenuItem;
    }
}