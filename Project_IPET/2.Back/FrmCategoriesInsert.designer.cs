
namespace Project_IPET
{
    partial class FrmCategoriesInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriesInsert));
            this.labCategoryName = new System.Windows.Forms.Label();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.btnInsertCategories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picCategoryImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labCategoryName
            // 
            this.labCategoryName.AutoSize = true;
            this.labCategoryName.BackColor = System.Drawing.SystemColors.Info;
            this.labCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCategoryName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCategoryName.Location = new System.Drawing.Point(13, 39);
            this.labCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCategoryName.Name = "labCategoryName";
            this.labCategoryName.Size = new System.Drawing.Size(135, 32);
            this.labCategoryName.TabIndex = 0;
            this.labCategoryName.Text = "類別名稱：";
            // 
            // txtCategories
            // 
            this.txtCategories.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCategories.Location = new System.Drawing.Point(137, 36);
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.Size = new System.Drawing.Size(154, 39);
            this.txtCategories.TabIndex = 1;
            // 
            // btnInsertCategories
            // 
            this.btnInsertCategories.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertCategories.Location = new System.Drawing.Point(300, 292);
            this.btnInsertCategories.Name = "btnInsertCategories";
            this.btnInsertCategories.Size = new System.Drawing.Size(105, 42);
            this.btnInsertCategories.TabIndex = 2;
            this.btnInsertCategories.Text = "新增類別";
            this.btnInsertCategories.UseVisualStyleBackColor = true;
            this.btnInsertCategories.Click += new System.EventHandler(this.btnInsertCategories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "類別圖片：";
            // 
            // picCategoryImage
            // 
            this.picCategoryImage.Location = new System.Drawing.Point(137, 123);
            this.picCategoryImage.Name = "picCategoryImage";
            this.picCategoryImage.Size = new System.Drawing.Size(268, 149);
            this.picCategoryImage.TabIndex = 31;
            this.picCategoryImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowseImage.Location = new System.Drawing.Point(421, 123);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(141, 44);
            this.btnBrowseImage.TabIndex = 40;
            this.btnBrowseImage.Text = "選擇圖片";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // FrmCategoriesInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 441);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.picCategoryImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertCategories);
            this.Controls.Add(this.txtCategories);
            this.Controls.Add(this.labCategoryName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoriesInsert";
            this.Text = "類別管理";
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCategoryName;
        private System.Windows.Forms.TextBox txtCategories;
        private System.Windows.Forms.Button btnInsertCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCategoryImage;
        private System.Windows.Forms.Button btnBrowseImage;
    }
}