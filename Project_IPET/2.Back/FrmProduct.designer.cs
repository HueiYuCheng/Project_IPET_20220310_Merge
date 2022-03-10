
namespace Project_IPET
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.labInertTable = new System.Windows.Forms.Label();
            this.labProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labUnitsInStock = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.labProductDescription = new System.Windows.Forms.Label();
            this.labProductCategoryID = new System.Windows.Forms.Label();
            this.labProductSubCategoryID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labProductImage = new System.Windows.Forms.Label();
            this.picBoxProductImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.labProductCategoryName = new System.Windows.Forms.Label();
            this.cbxProductCategoryID = new System.Windows.Forms.ComboBox();
            this.cbxProductSubCategoryID = new System.Windows.Forms.ComboBox();
            this.cbxProductBrandName = new System.Windows.Forms.ComboBox();
            this.labProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labInertTable
            // 
            this.labInertTable.AutoSize = true;
            this.labInertTable.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInertTable.Location = new System.Drawing.Point(12, 9);
            this.labInertTable.Name = "labInertTable";
            this.labInertTable.Size = new System.Drawing.Size(240, 38);
            this.labInertTable.TabIndex = 0;
            this.labInertTable.Text = "產品新增/修改表";
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.BackColor = System.Drawing.SystemColors.Info;
            this.labProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labProductName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductName.Location = new System.Drawing.Point(12, 58);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(135, 32);
            this.labProductName.TabIndex = 1;
            this.labProductName.Text = "商品名稱：";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(137, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 34);
            this.txtProductName.TabIndex = 6;
            // 
            // labUnitsInStock
            // 
            this.labUnitsInStock.AutoSize = true;
            this.labUnitsInStock.BackColor = System.Drawing.SystemColors.Info;
            this.labUnitsInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labUnitsInStock.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUnitsInStock.Location = new System.Drawing.Point(12, 151);
            this.labUnitsInStock.Name = "labUnitsInStock";
            this.labUnitsInStock.Size = new System.Drawing.Size(135, 32);
            this.labUnitsInStock.TabIndex = 11;
            this.labUnitsInStock.Text = "商品庫存：";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitsInStock.Location = new System.Drawing.Point(135, 145);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(100, 34);
            this.txtUnitsInStock.TabIndex = 14;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.AllowDrop = true;
            this.txtProductDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(412, 49);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtProductDescription.Size = new System.Drawing.Size(313, 163);
            this.txtProductDescription.TabIndex = 16;
            // 
            // labProductDescription
            // 
            this.labProductDescription.AutoSize = true;
            this.labProductDescription.BackColor = System.Drawing.SystemColors.Info;
            this.labProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labProductDescription.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductDescription.Location = new System.Drawing.Point(294, 55);
            this.labProductDescription.Name = "labProductDescription";
            this.labProductDescription.Size = new System.Drawing.Size(135, 32);
            this.labProductDescription.TabIndex = 15;
            this.labProductDescription.Text = "商品描述：";
            // 
            // labProductCategoryID
            // 
            this.labProductCategoryID.AutoSize = true;
            this.labProductCategoryID.BackColor = System.Drawing.SystemColors.Info;
            this.labProductCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labProductCategoryID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductCategoryID.Location = new System.Drawing.Point(734, 45);
            this.labProductCategoryID.Name = "labProductCategoryID";
            this.labProductCategoryID.Size = new System.Drawing.Size(159, 32);
            this.labProductCategoryID.TabIndex = 17;
            this.labProductCategoryID.Text = "商品主分類：";
            // 
            // labProductSubCategoryID
            // 
            this.labProductSubCategoryID.AutoSize = true;
            this.labProductSubCategoryID.BackColor = System.Drawing.SystemColors.Info;
            this.labProductSubCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labProductSubCategoryID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductSubCategoryID.Location = new System.Drawing.Point(734, 99);
            this.labProductSubCategoryID.Name = "labProductSubCategoryID";
            this.labProductSubCategoryID.Size = new System.Drawing.Size(159, 32);
            this.labProductSubCategoryID.TabIndex = 19;
            this.labProductSubCategoryID.Text = "商品次分類：";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(926, 550);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 36);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAll.Location = new System.Drawing.Point(749, 550);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(168, 36);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.Text = "清空文字";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // labProductImage
            // 
            this.labProductImage.AutoSize = true;
            this.labProductImage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductImage.Location = new System.Drawing.Point(12, 248);
            this.labProductImage.Name = "labProductImage";
            this.labProductImage.Size = new System.Drawing.Size(137, 38);
            this.labProductImage.TabIndex = 37;
            this.labProductImage.Text = "產品圖片";
            // 
            // picBoxProductImage
            // 
            this.picBoxProductImage.Location = new System.Drawing.Point(19, 292);
            this.picBoxProductImage.Name = "picBoxProductImage";
            this.picBoxProductImage.Size = new System.Drawing.Size(706, 161);
            this.picBoxProductImage.TabIndex = 38;
            this.picBoxProductImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowseImage.Location = new System.Drawing.Point(171, 242);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(205, 44);
            this.btnBrowseImage.TabIndex = 39;
            this.btnBrowseImage.Text = "選擇圖片";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // labProductCategoryName
            // 
            this.labProductCategoryName.AutoSize = true;
            this.labProductCategoryName.BackColor = System.Drawing.SystemColors.Info;
            this.labProductCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labProductCategoryName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductCategoryName.Location = new System.Drawing.Point(734, 151);
            this.labProductCategoryName.Name = "labProductCategoryName";
            this.labProductCategoryName.Size = new System.Drawing.Size(183, 32);
            this.labProductCategoryName.TabIndex = 40;
            this.labProductCategoryName.Text = "商品品牌名稱：";
            // 
            // cbxProductCategoryID
            // 
            this.cbxProductCategoryID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductCategoryID.FormattingEnabled = true;
            this.cbxProductCategoryID.Location = new System.Drawing.Point(885, 40);
            this.cbxProductCategoryID.Name = "cbxProductCategoryID";
            this.cbxProductCategoryID.Size = new System.Drawing.Size(129, 33);
            this.cbxProductCategoryID.TabIndex = 42;
            this.cbxProductCategoryID.SelectedIndexChanged += new System.EventHandler(this.cbxProductCategoryID_SelectedIndexChanged);
            // 
            // cbxProductSubCategoryID
            // 
            this.cbxProductSubCategoryID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductSubCategoryID.FormattingEnabled = true;
            this.cbxProductSubCategoryID.Location = new System.Drawing.Point(885, 92);
            this.cbxProductSubCategoryID.Name = "cbxProductSubCategoryID";
            this.cbxProductSubCategoryID.Size = new System.Drawing.Size(129, 33);
            this.cbxProductSubCategoryID.TabIndex = 43;
            // 
            // cbxProductBrandName
            // 
            this.cbxProductBrandName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductBrandName.FormattingEnabled = true;
            this.cbxProductBrandName.Location = new System.Drawing.Point(885, 149);
            this.cbxProductBrandName.Name = "cbxProductBrandName";
            this.cbxProductBrandName.Size = new System.Drawing.Size(129, 33);
            this.cbxProductBrandName.TabIndex = 44;
            // 
            // labProductPrice
            // 
            this.labProductPrice.AutoSize = true;
            this.labProductPrice.BackColor = System.Drawing.SystemColors.Info;
            this.labProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labProductPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductPrice.Location = new System.Drawing.Point(12, 100);
            this.labProductPrice.Name = "labProductPrice";
            this.labProductPrice.Size = new System.Drawing.Size(135, 32);
            this.labProductPrice.TabIndex = 10;
            this.labProductPrice.Text = "商品售價：";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(135, 100);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 34);
            this.txtProductPrice.TabIndex = 13;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 623);
            this.Controls.Add(this.cbxProductBrandName);
            this.Controls.Add(this.cbxProductSubCategoryID);
            this.Controls.Add(this.cbxProductCategoryID);
            this.Controls.Add(this.labProductCategoryName);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.picBoxProductImage);
            this.Controls.Add(this.labProductImage);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labProductSubCategoryID);
            this.Controls.Add(this.labProductCategoryID);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.labProductDescription);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.labUnitsInStock);
            this.Controls.Add(this.labProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labProductName);
            this.Controls.Add(this.labInertTable);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProduct";
            this.Text = "FrmShoppingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInertTable;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label labProductDescription;
        private System.Windows.Forms.Label labProductCategoryID;
        private System.Windows.Forms.Label labProductSubCategoryID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label labProductImage;
        private System.Windows.Forms.PictureBox picBoxProductImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label labProductCategoryName;
        private System.Windows.Forms.ComboBox cbxProductCategoryID;
        private System.Windows.Forms.ComboBox cbxProductSubCategoryID;
        private System.Windows.Forms.ComboBox cbxProductBrandName;
        private System.Windows.Forms.Label labProductPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
    }
}