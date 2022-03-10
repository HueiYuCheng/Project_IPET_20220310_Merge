
namespace Project_IPET
{
    partial class FrmProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewFrm = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.groupBoxProductDetails = new System.Windows.Forms.GroupBox();
            this.pictureBoxShowProductImage = new System.Windows.Forms.PictureBox();
            this.labShowProductUnitsInStock = new System.Windows.Forms.Label();
            this.labShowProductUnitPrice = new System.Windows.Forms.Label();
            this.labShowProductBrand = new System.Windows.Forms.Label();
            this.labShowProductCategory = new System.Windows.Forms.Label();
            this.labShowProductID = new System.Windows.Forms.Label();
            this.labProductImage = new System.Windows.Forms.Label();
            this.labProductUnitsInStock = new System.Windows.Forms.Label();
            this.labProductBrand = new System.Windows.Forms.Label();
            this.labProductUnitPrice = new System.Windows.Forms.Label();
            this.labProductCategory = new System.Windows.Forms.Label();
            this.labProductID = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labProductSubCategoryID = new System.Windows.Forms.Label();
            this.labProductCategoryID = new System.Windows.Forms.Label();
            this.labProductBrandName = new System.Windows.Forms.Label();
            this.labSearchProduct = new System.Windows.Forms.Label();
            this.cbxProductCategoryID = new System.Windows.Forms.ComboBox();
            this.cbxProductBrandName = new System.Windows.Forms.ComboBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cbxProductSubCategoryID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.groupBoxProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowProductImage)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品資訊";
            // 
            // btnNewFrm
            // 
            this.btnNewFrm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewFrm.Location = new System.Drawing.Point(320, 557);
            this.btnNewFrm.Name = "btnNewFrm";
            this.btnNewFrm.Size = new System.Drawing.Size(125, 42);
            this.btnNewFrm.TabIndex = 3;
            this.btnNewFrm.Text = "新增";
            this.btnNewFrm.UseVisualStyleBackColor = true;
            this.btnNewFrm.Click += new System.EventHandler(this.btnNewFrm_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.ProductName,
            this.Category,
            this.colSubCategory});
            this.dgvProductList.Location = new System.Drawing.Point(12, 146);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 27;
            this.dgvProductList.Size = new System.Drawing.Size(433, 405);
            this.dgvProductList.TabIndex = 4;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            this.dgvProductList.SelectionChanged += new System.EventHandler(this.dgvProductList_SelectionChanged);
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxProductDetails.Controls.Add(this.pictureBoxShowProductImage);
            this.groupBoxProductDetails.Controls.Add(this.labShowProductUnitsInStock);
            this.groupBoxProductDetails.Controls.Add(this.labShowProductUnitPrice);
            this.groupBoxProductDetails.Controls.Add(this.labShowProductBrand);
            this.groupBoxProductDetails.Controls.Add(this.labShowProductCategory);
            this.groupBoxProductDetails.Controls.Add(this.labShowProductID);
            this.groupBoxProductDetails.Controls.Add(this.labProductImage);
            this.groupBoxProductDetails.Controls.Add(this.labProductUnitsInStock);
            this.groupBoxProductDetails.Controls.Add(this.labProductBrand);
            this.groupBoxProductDetails.Controls.Add(this.labProductUnitPrice);
            this.groupBoxProductDetails.Controls.Add(this.labProductCategory);
            this.groupBoxProductDetails.Controls.Add(this.labProductID);
            this.groupBoxProductDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductDetails.Location = new System.Drawing.Point(460, 146);
            this.groupBoxProductDetails.Name = "groupBoxProductDetails";
            this.groupBoxProductDetails.Size = new System.Drawing.Size(323, 426);
            this.groupBoxProductDetails.TabIndex = 33;
            this.groupBoxProductDetails.TabStop = false;
            this.groupBoxProductDetails.Text = "商品資料";
            // 
            // pictureBoxShowProductImage
            // 
            this.pictureBoxShowProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShowProductImage.Location = new System.Drawing.Point(111, 250);
            this.pictureBoxShowProductImage.Name = "pictureBoxShowProductImage";
            this.pictureBoxShowProductImage.Size = new System.Drawing.Size(200, 139);
            this.pictureBoxShowProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowProductImage.TabIndex = 13;
            this.pictureBoxShowProductImage.TabStop = false;
            // 
            // labShowProductUnitsInStock
            // 
            this.labShowProductUnitsInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowProductUnitsInStock.Location = new System.Drawing.Point(110, 211);
            this.labShowProductUnitsInStock.Name = "labShowProductUnitsInStock";
            this.labShowProductUnitsInStock.Size = new System.Drawing.Size(152, 21);
            this.labShowProductUnitsInStock.TabIndex = 12;
            // 
            // labShowProductUnitPrice
            // 
            this.labShowProductUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowProductUnitPrice.Location = new System.Drawing.Point(110, 172);
            this.labShowProductUnitPrice.Name = "labShowProductUnitPrice";
            this.labShowProductUnitPrice.Size = new System.Drawing.Size(152, 21);
            this.labShowProductUnitPrice.TabIndex = 11;
            // 
            // labShowProductBrand
            // 
            this.labShowProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowProductBrand.Location = new System.Drawing.Point(111, 134);
            this.labShowProductBrand.Name = "labShowProductBrand";
            this.labShowProductBrand.Size = new System.Drawing.Size(152, 21);
            this.labShowProductBrand.TabIndex = 9;
            // 
            // labShowProductCategory
            // 
            this.labShowProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowProductCategory.Location = new System.Drawing.Point(111, 95);
            this.labShowProductCategory.Name = "labShowProductCategory";
            this.labShowProductCategory.Size = new System.Drawing.Size(173, 21);
            this.labShowProductCategory.TabIndex = 8;
            // 
            // labShowProductID
            // 
            this.labShowProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowProductID.Location = new System.Drawing.Point(111, 51);
            this.labShowProductID.Name = "labShowProductID";
            this.labShowProductID.Size = new System.Drawing.Size(167, 21);
            this.labShowProductID.TabIndex = 7;
            // 
            // labProductImage
            // 
            this.labProductImage.AutoSize = true;
            this.labProductImage.Location = new System.Drawing.Point(15, 250);
            this.labProductImage.Name = "labProductImage";
            this.labProductImage.Size = new System.Drawing.Size(112, 25);
            this.labProductImage.TabIndex = 6;
            this.labProductImage.Text = "商品圖片：";
            // 
            // labProductUnitsInStock
            // 
            this.labProductUnitsInStock.AutoSize = true;
            this.labProductUnitsInStock.Location = new System.Drawing.Point(14, 211);
            this.labProductUnitsInStock.Name = "labProductUnitsInStock";
            this.labProductUnitsInStock.Size = new System.Drawing.Size(92, 25);
            this.labProductUnitsInStock.TabIndex = 5;
            this.labProductUnitsInStock.Text = "庫存量：";
            // 
            // labProductBrand
            // 
            this.labProductBrand.AutoSize = true;
            this.labProductBrand.Location = new System.Drawing.Point(15, 134);
            this.labProductBrand.Name = "labProductBrand";
            this.labProductBrand.Size = new System.Drawing.Size(112, 25);
            this.labProductBrand.TabIndex = 4;
            this.labProductBrand.Text = "商品品牌：";
            // 
            // labProductUnitPrice
            // 
            this.labProductUnitPrice.AutoSize = true;
            this.labProductUnitPrice.Location = new System.Drawing.Point(14, 172);
            this.labProductUnitPrice.Name = "labProductUnitPrice";
            this.labProductUnitPrice.Size = new System.Drawing.Size(112, 25);
            this.labProductUnitPrice.TabIndex = 3;
            this.labProductUnitPrice.Text = "商品單價：";
            // 
            // labProductCategory
            // 
            this.labProductCategory.AutoSize = true;
            this.labProductCategory.Location = new System.Drawing.Point(15, 95);
            this.labProductCategory.Name = "labProductCategory";
            this.labProductCategory.Size = new System.Drawing.Size(112, 25);
            this.labProductCategory.TabIndex = 1;
            this.labProductCategory.Text = "商品類別：";
            // 
            // labProductID
            // 
            this.labProductID.AutoSize = true;
            this.labProductID.Location = new System.Drawing.Point(16, 51);
            this.labProductID.Name = "labProductID";
            this.labProductID.Size = new System.Drawing.Size(112, 25);
            this.labProductID.TabIndex = 0;
            this.labProductID.Text = "商品名稱：";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxSearch.Controls.Add(this.labProductSubCategoryID);
            this.groupBoxSearch.Controls.Add(this.labProductCategoryID);
            this.groupBoxSearch.Controls.Add(this.labProductBrandName);
            this.groupBoxSearch.Controls.Add(this.labSearchProduct);
            this.groupBoxSearch.Controls.Add(this.cbxProductCategoryID);
            this.groupBoxSearch.Controls.Add(this.cbxProductBrandName);
            this.groupBoxSearch.Controls.Add(this.txtSearchProduct);
            this.groupBoxSearch.Controls.Add(this.cbxProductSubCategoryID);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(789, 146);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(387, 271);
            this.groupBoxSearch.TabIndex = 34;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "查詢";
            // 
            // labProductSubCategoryID
            // 
            this.labProductSubCategoryID.AutoSize = true;
            this.labProductSubCategoryID.Location = new System.Drawing.Point(30, 144);
            this.labProductSubCategoryID.Name = "labProductSubCategoryID";
            this.labProductSubCategoryID.Size = new System.Drawing.Size(132, 25);
            this.labProductSubCategoryID.TabIndex = 33;
            this.labProductSubCategoryID.Text = "產品子分類：";
            // 
            // labProductCategoryID
            // 
            this.labProductCategoryID.AutoSize = true;
            this.labProductCategoryID.Location = new System.Drawing.Point(30, 104);
            this.labProductCategoryID.Name = "labProductCategoryID";
            this.labProductCategoryID.Size = new System.Drawing.Size(132, 25);
            this.labProductCategoryID.TabIndex = 32;
            this.labProductCategoryID.Text = "產品主分類：";
            // 
            // labProductBrandName
            // 
            this.labProductBrandName.AutoSize = true;
            this.labProductBrandName.Location = new System.Drawing.Point(30, 69);
            this.labProductBrandName.Name = "labProductBrandName";
            this.labProductBrandName.Size = new System.Drawing.Size(152, 25);
            this.labProductBrandName.TabIndex = 31;
            this.labProductBrandName.Text = "產品品牌名稱：";
            // 
            // labSearchProduct
            // 
            this.labSearchProduct.AutoSize = true;
            this.labSearchProduct.Location = new System.Drawing.Point(30, 29);
            this.labSearchProduct.Name = "labSearchProduct";
            this.labSearchProduct.Size = new System.Drawing.Size(112, 25);
            this.labSearchProduct.TabIndex = 30;
            this.labSearchProduct.Text = "產品搜尋：";
            // 
            // cbxProductCategoryID
            // 
            this.cbxProductCategoryID.FormattingEnabled = true;
            this.cbxProductCategoryID.Location = new System.Drawing.Point(158, 96);
            this.cbxProductCategoryID.Name = "cbxProductCategoryID";
            this.cbxProductCategoryID.Size = new System.Drawing.Size(168, 33);
            this.cbxProductCategoryID.TabIndex = 29;
            this.cbxProductCategoryID.SelectedIndexChanged += new System.EventHandler(this.cbxProductCategoryID_SelectedIndexChanged);
            // 
            // cbxProductBrandName
            // 
            this.cbxProductBrandName.FormattingEnabled = true;
            this.cbxProductBrandName.Location = new System.Drawing.Point(158, 61);
            this.cbxProductBrandName.Name = "cbxProductBrandName";
            this.cbxProductBrandName.Size = new System.Drawing.Size(212, 33);
            this.cbxProductBrandName.TabIndex = 28;
            this.cbxProductBrandName.SelectedIndexChanged += new System.EventHandler(this.cbxProductBrandName_SelectedIndexChanged);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(158, 26);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(212, 34);
            this.txtSearchProduct.TabIndex = 27;
            // 
            // cbxProductSubCategoryID
            // 
            this.cbxProductSubCategoryID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductSubCategoryID.FormattingEnabled = true;
            this.cbxProductSubCategoryID.Location = new System.Drawing.Point(158, 144);
            this.cbxProductSubCategoryID.Name = "cbxProductSubCategoryID";
            this.cbxProductSubCategoryID.Size = new System.Drawing.Size(168, 33);
            this.cbxProductSubCategoryID.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(238, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 48);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Khaki;
            this.btnCategory.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCategory.Location = new System.Drawing.Point(302, 88);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(143, 42);
            this.btnCategory.TabIndex = 35;
            this.btnCategory.Text = "管理產品類別";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "ID";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = false;
            this.colProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "產品名稱";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "主類別";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // colSubCategory
            // 
            this.colSubCategory.HeaderText = "次類別";
            this.colSubCategory.MinimumWidth = 6;
            this.colSubCategory.Name = "colSubCategory";
            this.colSubCategory.Width = 125;
            // 
            // FrmProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1588, 987);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxProductDetails);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnNewFrm);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProductPage";
            this.Text = "FrmShoppingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowProductImage)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewFrm;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.GroupBox groupBoxProductDetails;
        private System.Windows.Forms.PictureBox pictureBoxShowProductImage;
        private System.Windows.Forms.Label labShowProductUnitsInStock;
        private System.Windows.Forms.Label labShowProductUnitPrice;
        private System.Windows.Forms.Label labShowProductBrand;
        private System.Windows.Forms.Label labShowProductCategory;
        private System.Windows.Forms.Label labShowProductID;
        private System.Windows.Forms.Label labProductImage;
        private System.Windows.Forms.Label labProductUnitsInStock;
        private System.Windows.Forms.Label labProductBrand;
        private System.Windows.Forms.Label labProductUnitPrice;
        private System.Windows.Forms.Label labProductCategory;
        private System.Windows.Forms.Label labProductID;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox cbxProductBrandName;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.ComboBox cbxProductSubCategoryID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.ComboBox cbxProductCategoryID;
        private System.Windows.Forms.Label labProductSubCategoryID;
        private System.Windows.Forms.Label labProductCategoryID;
        private System.Windows.Forms.Label labProductBrandName;
        private System.Windows.Forms.Label labSearchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCategory;
    }
}