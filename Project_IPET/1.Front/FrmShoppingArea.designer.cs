
namespace Project_IPET
{
    partial class FrmShoppingArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShoppingArea));
            this.labShopping = new System.Windows.Forms.Label();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxSubCategory = new System.Windows.Forms.ComboBox();
            this.labFilter = new System.Windows.Forms.Label();
            this.labQuantity = new System.Windows.Forms.Label();
            this.gbxDeliveryType = new System.Windows.Forms.GroupBox();
            this.rbtnInStorePickup = new System.Windows.Forms.RadioButton();
            this.rbtnHomeDelivery = new System.Windows.Forms.RadioButton();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dataGridViewShoppingCart = new System.Windows.Forms.DataGridView();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtnCashOnDelivery = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnDonateMode = new System.Windows.Forms.RadioButton();
            this.rbtnBuyMode = new System.Windows.Forms.RadioButton();
            this.labFreight = new System.Windows.Forms.Label();
            this.labProductPrice = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.gbxShoppingCart = new System.Windows.Forms.GroupBox();
            this.gbxFunction = new System.Windows.Forms.GroupBox();
            this.labCart = new System.Windows.Forms.Label();
            this.gbxCheckOutOption = new System.Windows.Forms.GroupBox();
            this.gbxOderInfo = new System.Windows.Forms.GroupBox();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.txtOrderPhone = new System.Windows.Forms.TextBox();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.labOrderAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labOrderName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.gbxDeliveryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShoppingCart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxShoppingCart.SuspendLayout();
            this.gbxFunction.SuspendLayout();
            this.gbxCheckOutOption.SuspendLayout();
            this.gbxOderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labShopping
            // 
            this.labShopping.AutoSize = true;
            this.labShopping.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labShopping.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShopping.ForeColor = System.Drawing.SystemColors.Control;
            this.labShopping.Location = new System.Drawing.Point(17, 30);
            this.labShopping.Margin = new System.Windows.Forms.Padding(0);
            this.labShopping.Name = "labShopping";
            this.labShopping.Size = new System.Drawing.Size(86, 24);
            this.labShopping.TabIndex = 0;
            this.labShopping.Text = "商品選購";
            this.labShopping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProductList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductList.ColumnHeadersHeight = 28;
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductList.Location = new System.Drawing.Point(16, 68);
            this.dataGridViewProductList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductList.RowHeadersWidth = 62;
            this.dataGridViewProductList.RowTemplate.Height = 31;
            this.dataGridViewProductList.Size = new System.Drawing.Size(604, 220);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.DoubleClick += new System.EventHandler(this.dataGridViewProductList_DoubleClick);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(245, 29);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(92, 27);
            this.cbxCategory.TabIndex = 2;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // cbxSubCategory
            // 
            this.cbxSubCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxSubCategory.FormattingEnabled = true;
            this.cbxSubCategory.Location = new System.Drawing.Point(353, 29);
            this.cbxSubCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSubCategory.Name = "cbxSubCategory";
            this.cbxSubCategory.Size = new System.Drawing.Size(126, 27);
            this.cbxSubCategory.TabIndex = 3;
            this.cbxSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSubCategory_SelectedIndexChanged);
            // 
            // labFilter
            // 
            this.labFilter.AutoSize = true;
            this.labFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labFilter.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.labFilter.Location = new System.Drawing.Point(131, 30);
            this.labFilter.Name = "labFilter";
            this.labFilter.Size = new System.Drawing.Size(96, 24);
            this.labFilter.TabIndex = 4;
            this.labFilter.Text = "分類篩選 :";
            this.labFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labQuantity.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.labQuantity.Location = new System.Drawing.Point(17, 314);
            this.labQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(91, 24);
            this.labQuantity.TabIndex = 5;
            this.labQuantity.Text = "購買數量:";
            this.labQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxDeliveryType
            // 
            this.gbxDeliveryType.BackColor = System.Drawing.Color.DimGray;
            this.gbxDeliveryType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDeliveryType.Controls.Add(this.rbtnInStorePickup);
            this.gbxDeliveryType.Controls.Add(this.rbtnHomeDelivery);
            this.gbxDeliveryType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxDeliveryType.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDeliveryType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxDeliveryType.Location = new System.Drawing.Point(64, 34);
            this.gbxDeliveryType.Margin = new System.Windows.Forms.Padding(0);
            this.gbxDeliveryType.Name = "gbxDeliveryType";
            this.gbxDeliveryType.Padding = new System.Windows.Forms.Padding(0);
            this.gbxDeliveryType.Size = new System.Drawing.Size(181, 87);
            this.gbxDeliveryType.TabIndex = 9;
            this.gbxDeliveryType.TabStop = false;
            this.gbxDeliveryType.Text = "選擇運送方式";
            // 
            // rbtnInStorePickup
            // 
            this.rbtnInStorePickup.AutoSize = true;
            this.rbtnInStorePickup.Location = new System.Drawing.Point(12, 46);
            this.rbtnInStorePickup.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnInStorePickup.Name = "rbtnInStorePickup";
            this.rbtnInStorePickup.Size = new System.Drawing.Size(104, 28);
            this.rbtnInStorePickup.TabIndex = 19;
            this.rbtnInStorePickup.TabStop = true;
            this.rbtnInStorePickup.Text = "超商取貨";
            this.rbtnInStorePickup.UseVisualStyleBackColor = true;
            // 
            // rbtnHomeDelivery
            // 
            this.rbtnHomeDelivery.AutoSize = true;
            this.rbtnHomeDelivery.Location = new System.Drawing.Point(12, 23);
            this.rbtnHomeDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnHomeDelivery.Name = "rbtnHomeDelivery";
            this.rbtnHomeDelivery.Size = new System.Drawing.Size(66, 28);
            this.rbtnHomeDelivery.TabIndex = 18;
            this.rbtnHomeDelivery.TabStop = true;
            this.rbtnHomeDelivery.Text = "宅配";
            this.rbtnHomeDelivery.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AutoSize = true;
            this.btnAddToCart.BackColor = System.Drawing.Color.Crimson;
            this.btnAddToCart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToCart.Location = new System.Drawing.Point(200, 309);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(115, 34);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "加入購物車";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dataGridViewShoppingCart
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShoppingCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShoppingCart.ColumnHeadersHeight = 28;
            this.dataGridViewShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShoppingCart.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewShoppingCart.Location = new System.Drawing.Point(16, 396);
            this.dataGridViewShoppingCart.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShoppingCart.Name = "dataGridViewShoppingCart";
            this.dataGridViewShoppingCart.RowHeadersWidth = 62;
            this.dataGridViewShoppingCart.RowTemplate.Height = 31;
            this.dataGridViewShoppingCart.Size = new System.Drawing.Size(604, 249);
            this.dataGridViewShoppingCart.TabIndex = 12;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AutoSize = true;
            this.btnDeleteItem.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnDeleteItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteItem.Location = new System.Drawing.Point(24, 35);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(115, 41);
            this.btnDeleteItem.TabIndex = 15;
            this.btnDeleteItem.Text = "移除該商品";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.AutoSize = true;
            this.btnClearCart.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnClearCart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearCart.Location = new System.Drawing.Point(25, 82);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(114, 41);
            this.btnClearCart.TabIndex = 16;
            this.btnClearCart.Text = "清空購物車";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckout.Location = new System.Drawing.Point(155, 35);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(72, 41);
            this.btnCheckout.TabIndex = 17;
            this.btnCheckout.Text = "結帳";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.rbtnCreditCard);
            this.groupBox1.Controls.Add(this.rbtnCashOnDelivery);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(287, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(168, 87);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇付款方式";
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Location = new System.Drawing.Point(12, 46);
            this.rbtnCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(85, 28);
            this.rbtnCreditCard.TabIndex = 19;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "信用卡";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCashOnDelivery
            // 
            this.rbtnCashOnDelivery.AutoSize = true;
            this.rbtnCashOnDelivery.Location = new System.Drawing.Point(12, 23);
            this.rbtnCashOnDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCashOnDelivery.Name = "rbtnCashOnDelivery";
            this.rbtnCashOnDelivery.Size = new System.Drawing.Size(104, 28);
            this.rbtnCashOnDelivery.TabIndex = 18;
            this.rbtnCashOnDelivery.TabStop = true;
            this.rbtnCashOnDelivery.Text = "貨到付款";
            this.rbtnCashOnDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.rbtnDonateMode);
            this.groupBox2.Controls.Add(this.rbtnBuyMode);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(64, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(181, 83);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選擇交易模式";
            // 
            // rbtnDonateMode
            // 
            this.rbtnDonateMode.AutoSize = true;
            this.rbtnDonateMode.Location = new System.Drawing.Point(12, 46);
            this.rbtnDonateMode.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDonateMode.Name = "rbtnDonateMode";
            this.rbtnDonateMode.Size = new System.Drawing.Size(104, 28);
            this.rbtnDonateMode.TabIndex = 19;
            this.rbtnDonateMode.TabStop = true;
            this.rbtnDonateMode.Text = "捐贈物資";
            this.rbtnDonateMode.UseVisualStyleBackColor = true;
            // 
            // rbtnBuyMode
            // 
            this.rbtnBuyMode.AutoSize = true;
            this.rbtnBuyMode.Location = new System.Drawing.Point(12, 23);
            this.rbtnBuyMode.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnBuyMode.Name = "rbtnBuyMode";
            this.rbtnBuyMode.Size = new System.Drawing.Size(104, 28);
            this.rbtnBuyMode.TabIndex = 18;
            this.rbtnBuyMode.TabStop = true;
            this.rbtnBuyMode.Text = "購買商品";
            this.rbtnBuyMode.UseVisualStyleBackColor = true;
            // 
            // labFreight
            // 
            this.labFreight.AutoSize = true;
            this.labFreight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labFreight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFreight.ForeColor = System.Drawing.SystemColors.Control;
            this.labFreight.Location = new System.Drawing.Point(17, 35);
            this.labFreight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFreight.Name = "labFreight";
            this.labFreight.Size = new System.Drawing.Size(96, 21);
            this.labFreight.TabIndex = 22;
            this.labFreight.Text = "運費 : NT$0";
            // 
            // labProductPrice
            // 
            this.labProductPrice.AutoSize = true;
            this.labProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labProductPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProductPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labProductPrice.Location = new System.Drawing.Point(17, 72);
            this.labProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProductPrice.Name = "labProductPrice";
            this.labProductPrice.Size = new System.Drawing.Size(128, 21);
            this.labProductPrice.TabIndex = 23;
            this.labProductPrice.Text = "商品金額 : NT$0";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.BackColor = System.Drawing.Color.DarkBlue;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labTotal.Location = new System.Drawing.Point(17, 110);
            this.labTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(198, 21);
            this.labTotal.TabIndex = 24;
            this.labTotal.Text = "總金額 ( 0 個商品 ) : NT$0";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuantity.ForeColor = System.Drawing.Color.Black;
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxQuantity.Location = new System.Drawing.Point(126, 313);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(54, 29);
            this.cbxQuantity.TabIndex = 25;
            this.cbxQuantity.Text = "1";
            // 
            // gbxShoppingCart
            // 
            this.gbxShoppingCart.BackColor = System.Drawing.Color.DimGray;
            this.gbxShoppingCart.Controls.Add(this.labFreight);
            this.gbxShoppingCart.Controls.Add(this.labProductPrice);
            this.gbxShoppingCart.Controls.Add(this.labTotal);
            this.gbxShoppingCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxShoppingCart.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxShoppingCart.Location = new System.Drawing.Point(668, 448);
            this.gbxShoppingCart.Name = "gbxShoppingCart";
            this.gbxShoppingCart.Size = new System.Drawing.Size(245, 197);
            this.gbxShoppingCart.TabIndex = 26;
            this.gbxShoppingCart.TabStop = false;
            this.gbxShoppingCart.Text = "購物車資訊";
            // 
            // gbxFunction
            // 
            this.gbxFunction.BackColor = System.Drawing.Color.DimGray;
            this.gbxFunction.Controls.Add(this.btnDeleteItem);
            this.gbxFunction.Controls.Add(this.btnClearCart);
            this.gbxFunction.Controls.Add(this.btnCheckout);
            this.gbxFunction.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxFunction.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxFunction.Location = new System.Drawing.Point(932, 448);
            this.gbxFunction.Name = "gbxFunction";
            this.gbxFunction.Size = new System.Drawing.Size(245, 197);
            this.gbxFunction.TabIndex = 27;
            this.gbxFunction.TabStop = false;
            this.gbxFunction.Text = "功能";
            // 
            // labCart
            // 
            this.labCart.AutoSize = true;
            this.labCart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCart.ForeColor = System.Drawing.SystemColors.Control;
            this.labCart.Location = new System.Drawing.Point(17, 361);
            this.labCart.Margin = new System.Windows.Forms.Padding(0);
            this.labCart.Name = "labCart";
            this.labCart.Size = new System.Drawing.Size(67, 24);
            this.labCart.TabIndex = 28;
            this.labCart.Text = "購物車";
            this.labCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxCheckOutOption
            // 
            this.gbxCheckOutOption.BackColor = System.Drawing.Color.DimGray;
            this.gbxCheckOutOption.Controls.Add(this.gbxDeliveryType);
            this.gbxCheckOutOption.Controls.Add(this.groupBox1);
            this.gbxCheckOutOption.Controls.Add(this.groupBox2);
            this.gbxCheckOutOption.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxCheckOutOption.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxCheckOutOption.Location = new System.Drawing.Point(668, 30);
            this.gbxCheckOutOption.Name = "gbxCheckOutOption";
            this.gbxCheckOutOption.Size = new System.Drawing.Size(509, 238);
            this.gbxCheckOutOption.TabIndex = 29;
            this.gbxCheckOutOption.TabStop = false;
            this.gbxCheckOutOption.Text = "結帳選項";
            // 
            // gbxOderInfo
            // 
            this.gbxOderInfo.BackColor = System.Drawing.Color.DimGray;
            this.gbxOderInfo.Controls.Add(this.txtOrderAddress);
            this.gbxOderInfo.Controls.Add(this.txtOrderPhone);
            this.gbxOderInfo.Controls.Add(this.txtOrderName);
            this.gbxOderInfo.Controls.Add(this.labOrderAddress);
            this.gbxOderInfo.Controls.Add(this.label2);
            this.gbxOderInfo.Controls.Add(this.labOrderName);
            this.gbxOderInfo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxOderInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxOderInfo.Location = new System.Drawing.Point(668, 292);
            this.gbxOderInfo.Name = "gbxOderInfo";
            this.gbxOderInfo.Size = new System.Drawing.Size(509, 136);
            this.gbxOderInfo.TabIndex = 30;
            this.gbxOderInfo.TabStop = false;
            this.gbxOderInfo.Text = "填寫訂購資料";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderAddress.Location = new System.Drawing.Point(101, 85);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(378, 29);
            this.txtOrderAddress.TabIndex = 36;
            this.txtOrderAddress.Text = "台北市大安區敦化南路二段331巷16號";
            this.txtOrderAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderPhone
            // 
            this.txtOrderPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderPhone.Location = new System.Drawing.Point(309, 34);
            this.txtOrderPhone.Name = "txtOrderPhone";
            this.txtOrderPhone.Size = new System.Drawing.Size(170, 29);
            this.txtOrderPhone.TabIndex = 35;
            this.txtOrderPhone.Text = "0912345678";
            this.txtOrderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderName
            // 
            this.txtOrderName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderName.Location = new System.Drawing.Point(101, 34);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(119, 29);
            this.txtOrderName.TabIndex = 34;
            this.txtOrderName.Text = "Peter";
            this.txtOrderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labOrderAddress
            // 
            this.labOrderAddress.AutoSize = true;
            this.labOrderAddress.Location = new System.Drawing.Point(27, 85);
            this.labOrderAddress.Name = "labOrderAddress";
            this.labOrderAddress.Size = new System.Drawing.Size(58, 24);
            this.labOrderAddress.TabIndex = 33;
            this.labOrderAddress.Text = "地址 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "電話 :";
            // 
            // labOrderName
            // 
            this.labOrderName.AutoSize = true;
            this.labOrderName.Location = new System.Drawing.Point(27, 34);
            this.labOrderName.Name = "labOrderName";
            this.labOrderName.Size = new System.Drawing.Size(58, 24);
            this.labOrderName.TabIndex = 31;
            this.labOrderName.Text = "姓名 :";
            // 
            // FrmShoppingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.gbxOderInfo);
            this.Controls.Add(this.gbxCheckOutOption);
            this.Controls.Add(this.labCart);
            this.Controls.Add(this.gbxFunction);
            this.Controls.Add(this.gbxShoppingCart);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.dataGridViewShoppingCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.labQuantity);
            this.Controls.Add(this.labFilter);
            this.Controls.Add(this.cbxSubCategory);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.dataGridViewProductList);
            this.Controls.Add(this.labShopping);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingArea";
            this.Text = "FrmShoppingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.gbxDeliveryType.ResumeLayout(false);
            this.gbxDeliveryType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShoppingCart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxShoppingCart.ResumeLayout(false);
            this.gbxShoppingCart.PerformLayout();
            this.gbxFunction.ResumeLayout(false);
            this.gbxFunction.PerformLayout();
            this.gbxCheckOutOption.ResumeLayout(false);
            this.gbxOderInfo.ResumeLayout(false);
            this.gbxOderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShopping;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxSubCategory;
        private System.Windows.Forms.Label labFilter;
        private System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.GroupBox gbxDeliveryType;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dataGridViewShoppingCart;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.RadioButton rbtnHomeDelivery;
        private System.Windows.Forms.RadioButton rbtnInStorePickup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.RadioButton rbtnCashOnDelivery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnDonateMode;
        private System.Windows.Forms.RadioButton rbtnBuyMode;
        private System.Windows.Forms.Label labFreight;
        private System.Windows.Forms.Label labProductPrice;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.GroupBox gbxShoppingCart;
        private System.Windows.Forms.GroupBox gbxFunction;
        private System.Windows.Forms.Label labCart;
        private System.Windows.Forms.GroupBox gbxCheckOutOption;
        private System.Windows.Forms.GroupBox gbxOderInfo;
        private System.Windows.Forms.Label labOrderAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labOrderName;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.TextBox txtOrderPhone;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
    }
}