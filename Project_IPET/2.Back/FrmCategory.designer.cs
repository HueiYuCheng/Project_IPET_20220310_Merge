
namespace Project_IPET
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.labFrmCategory = new System.Windows.Forms.Label();
            this.labSearchCategoryName = new System.Windows.Forms.Label();
            this.txtSearchCategoryName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtShowCategoryName = new System.Windows.Forms.TextBox();
            this.picCategoryImage = new System.Windows.Forms.PictureBox();
            this.labCategoryImage = new System.Windows.Forms.Label();
            this.labCategoryName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryPicture = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labFrmCategory
            // 
            this.labFrmCategory.AutoSize = true;
            this.labFrmCategory.BackColor = System.Drawing.SystemColors.Info;
            this.labFrmCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labFrmCategory.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFrmCategory.Location = new System.Drawing.Point(26, 18);
            this.labFrmCategory.Name = "labFrmCategory";
            this.labFrmCategory.Size = new System.Drawing.Size(193, 38);
            this.labFrmCategory.TabIndex = 0;
            this.labFrmCategory.Text = "FrmCategory";
            // 
            // labSearchCategoryName
            // 
            this.labSearchCategoryName.AutoSize = true;
            this.labSearchCategoryName.BackColor = System.Drawing.SystemColors.Info;
            this.labSearchCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSearchCategoryName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearchCategoryName.Location = new System.Drawing.Point(26, 76);
            this.labSearchCategoryName.Name = "labSearchCategoryName";
            this.labSearchCategoryName.Size = new System.Drawing.Size(225, 38);
            this.labSearchCategoryName.TabIndex = 2;
            this.labSearchCategoryName.Text = "CategoryName:";
            // 
            // txtSearchCategoryName
            // 
            this.txtSearchCategoryName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategoryName.Location = new System.Drawing.Point(266, 73);
            this.txtSearchCategoryName.Name = "txtSearchCategoryName";
            this.txtSearchCategoryName.Size = new System.Drawing.Size(192, 43);
            this.txtSearchCategoryName.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(90, 401);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 45);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "新增類別";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(182, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(220, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.CategoryPicture});
            this.dgvCategoryList.Location = new System.Drawing.Point(12, 237);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.RowHeadersWidth = 51;
            this.dgvCategoryList.RowTemplate.Height = 24;
            this.dgvCategoryList.Size = new System.Drawing.Size(332, 158);
            this.dgvCategoryList.TabIndex = 9;
            this.dgvCategoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryList_CellContentClick);
            this.dgvCategoryList.SelectionChanged += new System.EventHandler(this.dgvCategoryList_SelectionChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxSearch.Controls.Add(this.txtShowCategoryName);
            this.groupBoxSearch.Controls.Add(this.picCategoryImage);
            this.groupBoxSearch.Controls.Add(this.labCategoryImage);
            this.groupBoxSearch.Controls.Add(this.labCategoryName);
            this.groupBoxSearch.Controls.Add(this.btnUpdate);
            this.groupBoxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(478, 193);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(297, 303);
            this.groupBoxSearch.TabIndex = 35;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Update Category";
            // 
            // txtShowCategoryName
            // 
            this.txtShowCategoryName.Location = new System.Drawing.Point(135, 44);
            this.txtShowCategoryName.Name = "txtShowCategoryName";
            this.txtShowCategoryName.Size = new System.Drawing.Size(129, 34);
            this.txtShowCategoryName.TabIndex = 31;
            // 
            // picCategoryImage
            // 
            this.picCategoryImage.Location = new System.Drawing.Point(135, 94);
            this.picCategoryImage.Name = "picCategoryImage";
            this.picCategoryImage.Size = new System.Drawing.Size(129, 111);
            this.picCategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCategoryImage.TabIndex = 30;
            this.picCategoryImage.TabStop = false;
            // 
            // labCategoryImage
            // 
            this.labCategoryImage.AutoSize = true;
            this.labCategoryImage.Location = new System.Drawing.Point(35, 94);
            this.labCategoryImage.Name = "labCategoryImage";
            this.labCategoryImage.Size = new System.Drawing.Size(117, 25);
            this.labCategoryImage.TabIndex = 29;
            this.labCategoryImage.Text = "類別圖片： ";
            // 
            // labCategoryName
            // 
            this.labCategoryName.AutoSize = true;
            this.labCategoryName.Location = new System.Drawing.Point(35, 47);
            this.labCategoryName.Name = "labCategoryName";
            this.labCategoryName.Size = new System.Drawing.Size(117, 25);
            this.labCategoryName.TabIndex = 28;
            this.labCategoryName.Text = "類別名稱： ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(464, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 48);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            this.CategoryID.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 125;
            // 
            // CategoryPicture
            // 
            this.CategoryPicture.HeaderText = "CategoryPicture";
            this.CategoryPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CategoryPicture.MinimumWidth = 6;
            this.CategoryPicture.Name = "CategoryPicture";
            this.CategoryPicture.ReadOnly = true;
            this.CategoryPicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryPicture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryPicture.Width = 125;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 537);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dgvCategoryList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearchCategoryName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labSearchCategoryName);
            this.Controls.Add(this.labFrmCategory);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCategory";
            this.Text = "FrmShoppingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFrmCategory;
        private System.Windows.Forms.Label labSearchCategoryName;
        private System.Windows.Forms.TextBox txtSearchCategoryName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.PictureBox picCategoryImage;
        private System.Windows.Forms.Label labCategoryImage;
        private System.Windows.Forms.Label labCategoryName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtShowCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewImageColumn CategoryPicture;
    }
}