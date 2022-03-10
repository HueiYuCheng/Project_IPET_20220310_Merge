
namespace Project_IPET
{
    partial class FrmCommentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommentManagement));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbxRating = new System.Windows.Forms.ComboBox();
            this.dtpCommentDateFirst = new System.Windows.Forms.DateTimePicker();
            this.dtpCommentDateLast = new System.Windows.Forms.DateTimePicker();
            this.cbxMemberName = new System.Windows.Forms.ComboBox();
            this.dgvComment = new System.Windows.Forms.DataGridView();
            this.btnShieldComment = new System.Windows.Forms.Button();
            this.ckxFilterCommentDate = new System.Windows.Forms.CheckBox();
            this.ckxFilterRating = new System.Windows.Forms.CheckBox();
            this.ckxFilterMemberName = new System.Windows.Forms.CheckBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnCommentSort = new System.Windows.Forms.Button();
            this.ckxSortBanned = new System.Windows.Forms.CheckBox();
            this.ckxSortRating = new System.Windows.Forms.CheckBox();
            this.ckxSortCommentDate = new System.Windows.Forms.CheckBox();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.cbxReply = new System.Windows.Forms.ComboBox();
            this.labReply = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.btnCreateReply = new System.Windows.Forms.Button();
            this.btnDeleteReply = new System.Windows.Forms.Button();
            this.ckxFilterReply = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(12, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(242, 47);
            this.labTitle.TabIndex = 23;
            this.labTitle.Text = "評價管理系統";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAll.Location = new System.Drawing.Point(826, 158);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(158, 43);
            this.btnShowAll.TabIndex = 25;
            this.btnShowAll.Text = "顯示全部評價";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbxRating
            // 
            this.cbxRating.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxRating.FormattingEnabled = true;
            this.cbxRating.Location = new System.Drawing.Point(151, 341);
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.Size = new System.Drawing.Size(221, 34);
            this.cbxRating.TabIndex = 26;
            // 
            // dtpCommentDateFirst
            // 
            this.dtpCommentDateFirst.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpCommentDateFirst.Location = new System.Drawing.Point(151, 263);
            this.dtpCommentDateFirst.Name = "dtpCommentDateFirst";
            this.dtpCommentDateFirst.Size = new System.Drawing.Size(221, 35);
            this.dtpCommentDateFirst.TabIndex = 31;
            this.dtpCommentDateFirst.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtpCommentDateLast
            // 
            this.dtpCommentDateLast.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpCommentDateLast.Location = new System.Drawing.Point(151, 305);
            this.dtpCommentDateLast.Name = "dtpCommentDateLast";
            this.dtpCommentDateLast.Size = new System.Drawing.Size(221, 35);
            this.dtpCommentDateLast.TabIndex = 32;
            // 
            // cbxMemberName
            // 
            this.cbxMemberName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMemberName.FormattingEnabled = true;
            this.cbxMemberName.Location = new System.Drawing.Point(151, 387);
            this.cbxMemberName.Name = "cbxMemberName";
            this.cbxMemberName.Size = new System.Drawing.Size(221, 34);
            this.cbxMemberName.TabIndex = 35;
            // 
            // dgvComment
            // 
            this.dgvComment.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComment.Location = new System.Drawing.Point(12, 69);
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.RowTemplate.Height = 24;
            this.dgvComment.Size = new System.Drawing.Size(808, 181);
            this.dgvComment.TabIndex = 22;
            // 
            // btnShieldComment
            // 
            this.btnShieldComment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnShieldComment.Location = new System.Drawing.Point(826, 207);
            this.btnShieldComment.Name = "btnShieldComment";
            this.btnShieldComment.Size = new System.Drawing.Size(158, 43);
            this.btnShieldComment.TabIndex = 38;
            this.btnShieldComment.Text = "屏蔽留言";
            this.btnShieldComment.UseVisualStyleBackColor = true;
            this.btnShieldComment.Click += new System.EventHandler(this.btnShieldComment_Click);
            // 
            // ckxFilterCommentDate
            // 
            this.ckxFilterCommentDate.AutoSize = true;
            this.ckxFilterCommentDate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxFilterCommentDate.Location = new System.Drawing.Point(20, 268);
            this.ckxFilterCommentDate.Name = "ckxFilterCommentDate";
            this.ckxFilterCommentDate.Size = new System.Drawing.Size(125, 30);
            this.ckxFilterCommentDate.TabIndex = 40;
            this.ckxFilterCommentDate.Text = "日期篩選 :";
            this.ckxFilterCommentDate.UseVisualStyleBackColor = true;
            // 
            // ckxFilterRating
            // 
            this.ckxFilterRating.AutoSize = true;
            this.ckxFilterRating.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxFilterRating.Location = new System.Drawing.Point(20, 345);
            this.ckxFilterRating.Name = "ckxFilterRating";
            this.ckxFilterRating.Size = new System.Drawing.Size(125, 30);
            this.ckxFilterRating.TabIndex = 41;
            this.ckxFilterRating.Text = "星級篩選 :";
            this.ckxFilterRating.UseVisualStyleBackColor = true;
            // 
            // ckxFilterMemberName
            // 
            this.ckxFilterMemberName.AutoSize = true;
            this.ckxFilterMemberName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxFilterMemberName.Location = new System.Drawing.Point(20, 391);
            this.ckxFilterMemberName.Name = "ckxFilterMemberName";
            this.ckxFilterMemberName.Size = new System.Drawing.Size(125, 30);
            this.ckxFilterMemberName.TabIndex = 42;
            this.ckxFilterMemberName.Text = "會員篩選 :";
            this.ckxFilterMemberName.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnCommentSort
            // 
            this.btnCommentSort.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCommentSort.Location = new System.Drawing.Point(390, 439);
            this.btnCommentSort.Name = "btnCommentSort";
            this.btnCommentSort.Size = new System.Drawing.Size(156, 43);
            this.btnCommentSort.TabIndex = 43;
            this.btnCommentSort.Text = "開始篩選";
            this.btnCommentSort.UseVisualStyleBackColor = true;
            this.btnCommentSort.Click += new System.EventHandler(this.btnCommentSort_Click);
            // 
            // ckxSortBanned
            // 
            this.ckxSortBanned.AutoSize = true;
            this.ckxSortBanned.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxSortBanned.Location = new System.Drawing.Point(389, 386);
            this.ckxSortBanned.Name = "ckxSortBanned";
            this.ckxSortBanned.Size = new System.Drawing.Size(157, 30);
            this.ckxSortBanned.TabIndex = 46;
            this.ckxSortBanned.Text = "封鎖狀態排序";
            this.ckxSortBanned.UseVisualStyleBackColor = true;
            // 
            // ckxSortRating
            // 
            this.ckxSortRating.AutoSize = true;
            this.ckxSortRating.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxSortRating.Location = new System.Drawing.Point(389, 327);
            this.ckxSortRating.Name = "ckxSortRating";
            this.ckxSortRating.Size = new System.Drawing.Size(115, 30);
            this.ckxSortRating.TabIndex = 45;
            this.ckxSortRating.Text = "星級排序";
            this.ckxSortRating.UseVisualStyleBackColor = true;
            // 
            // ckxSortCommentDate
            // 
            this.ckxSortCommentDate.AutoSize = true;
            this.ckxSortCommentDate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxSortCommentDate.Location = new System.Drawing.Point(389, 263);
            this.ckxSortCommentDate.Name = "ckxSortCommentDate";
            this.ckxSortCommentDate.Size = new System.Drawing.Size(115, 30);
            this.ckxSortCommentDate.TabIndex = 44;
            this.ckxSortCommentDate.Text = "日期排序";
            this.ckxSortCommentDate.UseVisualStyleBackColor = true;
            // 
            // txtReply
            // 
            this.txtReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtReply.Location = new System.Drawing.Point(566, 386);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(254, 35);
            this.txtReply.TabIndex = 48;
            // 
            // cbxReply
            // 
            this.cbxReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxReply.FormattingEnabled = true;
            this.cbxReply.Location = new System.Drawing.Point(568, 303);
            this.cbxReply.Name = "cbxReply";
            this.cbxReply.Size = new System.Drawing.Size(254, 34);
            this.cbxReply.TabIndex = 50;
  
            this.cbxReply.Click += new System.EventHandler(this.cbxReply_Click);
            // 
            // labReply
            // 
            this.labReply.AutoSize = true;
            this.labReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.labReply.Location = new System.Drawing.Point(568, 262);
            this.labReply.Name = "labReply";
            this.labReply.Size = new System.Drawing.Size(148, 26);
            this.labReply.TabIndex = 51;
            this.labReply.Text = "快速評價回覆 :";
            // 
            // btnReply
            // 
            this.btnReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReply.Location = new System.Drawing.Point(566, 343);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(126, 32);
            this.btnReply.TabIndex = 52;
            this.btnReply.Text = "評價回覆";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // btnCreateReply
            // 
            this.btnCreateReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateReply.Location = new System.Drawing.Point(566, 439);
            this.btnCreateReply.Name = "btnCreateReply";
            this.btnCreateReply.Size = new System.Drawing.Size(209, 43);
            this.btnCreateReply.TabIndex = 53;
            this.btnCreateReply.Text = "新增快速回覆內容";
            this.btnCreateReply.UseVisualStyleBackColor = true;
            this.btnCreateReply.Click += new System.EventHandler(this.btnCreateReply_Click);
            // 
            // btnDeleteReply
            // 
            this.btnDeleteReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteReply.Location = new System.Drawing.Point(781, 439);
            this.btnDeleteReply.Name = "btnDeleteReply";
            this.btnDeleteReply.Size = new System.Drawing.Size(209, 43);
            this.btnDeleteReply.TabIndex = 55;
            this.btnDeleteReply.Text = "刪除快速回覆內容";
            this.btnDeleteReply.UseVisualStyleBackColor = true;
            this.btnDeleteReply.Click += new System.EventHandler(this.btnDeleteReply_Click);
            // 
            // ckxFilterReply
            // 
            this.ckxFilterReply.AutoSize = true;
            this.ckxFilterReply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckxFilterReply.Location = new System.Drawing.Point(20, 452);
            this.ckxFilterReply.Name = "ckxFilterReply";
            this.ckxFilterReply.Size = new System.Drawing.Size(188, 30);
            this.ckxFilterReply.TabIndex = 56;
            this.ckxFilterReply.Text = "未回覆評價篩選 :";
            this.ckxFilterReply.UseVisualStyleBackColor = true;
            // 
            // FrmCommentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 661);
            this.Controls.Add(this.ckxFilterReply);
            this.Controls.Add(this.btnDeleteReply);
            this.Controls.Add(this.btnCreateReply);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.labReply);
            this.Controls.Add(this.cbxReply);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.ckxSortBanned);
            this.Controls.Add(this.ckxSortRating);
            this.Controls.Add(this.ckxSortCommentDate);
            this.Controls.Add(this.btnCommentSort);
            this.Controls.Add(this.ckxFilterMemberName);
            this.Controls.Add(this.ckxFilterRating);
            this.Controls.Add(this.ckxFilterCommentDate);
            this.Controls.Add(this.btnShieldComment);
            this.Controls.Add(this.cbxMemberName);
            this.Controls.Add(this.dtpCommentDateLast);
            this.Controls.Add(this.dtpCommentDateFirst);
            this.Controls.Add(this.cbxRating);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.dgvComment);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCommentManagement";
            this.Text = "FrmCommentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cbxRating;
        private System.Windows.Forms.DateTimePicker dtpCommentDateFirst;
        private System.Windows.Forms.DateTimePicker dtpCommentDateLast;
        private System.Windows.Forms.ComboBox cbxMemberName;
        private System.Windows.Forms.DataGridView dgvComment;
        private System.Windows.Forms.Button btnShieldComment;
        private System.Windows.Forms.CheckBox ckxFilterCommentDate;
        private System.Windows.Forms.CheckBox ckxFilterRating;
        private System.Windows.Forms.CheckBox ckxFilterMemberName;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnCommentSort;
        private System.Windows.Forms.CheckBox ckxSortBanned;
        private System.Windows.Forms.CheckBox ckxSortRating;
        private System.Windows.Forms.CheckBox ckxSortCommentDate;
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.Button btnCreateReply;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label labReply;
        private System.Windows.Forms.ComboBox cbxReply;
        private System.Windows.Forms.Button btnDeleteReply;
        private System.Windows.Forms.CheckBox ckxFilterReply;
    }
}