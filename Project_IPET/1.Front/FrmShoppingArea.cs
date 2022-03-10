using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IPET
{
    public partial class FrmShoppingArea : Form
    {
        public FrmShoppingArea()
        {
            InitializeComponent();
            ShoppingCart_Init();
            Filter_Load();
            RegisterEvent();
        }

        // 類別變數
        MyProjectEntities dbContext = new MyProjectEntities();
        string SubCategoryName;
        int PID, Quantity, deliveryTypeID, paymentTypeID, transactionTypeID;
        int Freight = 60;


        // 初始化
        public void ShoppingCart_Init()
        {
            this.cbxSubCategory.Enabled = false;
            Product_Load();
            RefreshCart();
        }

        // 註冊事件
        public void RegisterEvent()
        {
            #region RadioButtons_Event
            this.rbtnHomeDelivery.CheckedChanged += RadioButtons_CheckedChanged;
            this.rbtnInStorePickup.CheckedChanged += RadioButtons_CheckedChanged;
            this.rbtnCashOnDelivery.CheckedChanged += RadioButtons_CheckedChanged;
            this.rbtnCreditCard.CheckedChanged += RadioButtons_CheckedChanged;
            this.rbtnBuyMode.CheckedChanged += RadioButtons_CheckedChanged;
            this.rbtnDonateMode.CheckedChanged += RadioButtons_CheckedChanged;
            #endregion
        }

        // 載入所有商品列表
        public void Product_Load()
        {
            this.dataGridViewProductList.DataSource = null;

            var product = from p in this.dbContext.Products.AsEnumerable()
                          select new
                          {
                              商品編號 = p.ProductID,
                              商品名稱 = p.ProductName,
                              商品主分類 = p.SubCategory.Category.CategoryName,
                              商品子分類 = p.SubCategory.SubCategoryName,
                              商品品牌 = p.Brand.BrandName,
                              商品價格 = $"{p.UnitPrice:c0}",
                              庫存數量 = p.UnitsInStock,
                              商品描述 = p.Description
                          };

            this.dataGridViewProductList.DataSource = product.ToList();
        }

        // 載入商品主分類選項
        public void Filter_Load()
        {
            List<Category> categories = dbContext.Categories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Rows.Add(-1, "所有商品");
            foreach (Category category in categories)
            {
                dt.Rows.Add(category.CategoryID, category.CategoryName);
            }
            this.cbxCategory.ValueMember = dt.Columns[0].ColumnName;
            this.cbxCategory.DisplayMember = dt.Columns[1].ColumnName;
            this.cbxCategory.DataSource = dt;
        }

        // 商品主分類選擇事件
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxSubCategory.Enabled = true;

            var CategoryID = Convert.ToInt32(this.cbxCategory.SelectedValue);
            var SubCategories = from sc in dbContext.SubCategories.AsEnumerable()
                                 where sc.CategoryID == CategoryID
                                 select sc.SubCategoryName;


            List<string> subcategories = SubCategories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Rows.Add("選擇子分類");
            foreach (string subcategory in subcategories)
            {
                dt.Rows.Add(subcategory);
            }
            this.cbxSubCategory.DisplayMember = dt.Columns[0].ColumnName;
            this.cbxSubCategory.DataSource = dt;

            //=====================================

            var FilterCategory = from p in this.dbContext.Products.AsEnumerable()
                                 where p.SubCategory.Category.CategoryID == CategoryID
                                 select new
                                 {
                                     商品編號 = p.ProductID,
                                     商品名稱 = p.ProductName,
                                     商品主分類 = p.SubCategory.Category.CategoryName,
                                     商品子分類 = p.SubCategory.SubCategoryName,
                                     商品品牌 = p.Brand.BrandName,
                                     商品價格 = $"{p.UnitPrice:c0}",
                                     庫存數量 = p.UnitsInStock,
                                     商品描述 = p.Description
                                 };

            this.dataGridViewProductList.DataSource = null;
            this.dataGridViewProductList.DataSource = FilterCategory.ToList();

            //=====================================

            if (this.cbxCategory.SelectedIndex == 0)
                {
                    Product_Load();
                    this.cbxSubCategory.Text = "";
                    this.cbxSubCategory.Enabled = false;
                }

        }

        // 商品子分類選擇事件
        private void cbxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoryName = this.cbxSubCategory.Text;
            var CategoryID = Convert.ToInt32(this.cbxCategory.SelectedValue);

            var FilterSubCategory = from p in this.dbContext.Products.AsEnumerable()
                                    where p.SubCategory.SubCategoryName == SubCategoryName
                                    select new
                                    {
                                        商品編號 = p.ProductID,
                                        商品名稱 = p.ProductName,
                                        商品主分類 = p.SubCategory.Category.CategoryName,
                                        商品子分類 = p.SubCategory.SubCategoryName,
                                        商品品牌 = p.Brand.BrandName,
                                        商品價格 = $"{p.UnitPrice:c0}",
                                        庫存數量 = p.UnitsInStock,
                                        商品描述 = p.Description
                                    };

            this.dataGridViewProductList.DataSource = null;
            this.dataGridViewProductList.DataSource = FilterSubCategory.ToList();

        }

        // 加入購物車
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int ProductUnitsInStock = (int)this.dataGridViewProductList.CurrentRow.Cells[6].Value;
            if ( ProductUnitsInStock <=0)
            {
                MessageBox.Show("此商品已無庫存, 請補貨時再購買", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.AddToCart();
            this.RefreshCart();
        }

        // 清空購物車
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            this.ClearCart();
            this.RefreshCart();
            this.labFreight.Text = "運費 : NT$0";
            this.labProductPrice.Text = "商品金額 : NT$0";
            this.labTotal.Text = "總金額 ( 0 個商品 ) : NT$0";
        }


        // 加入購物車方法
        public void AddToCart()
        {
            PID = (int)this.dataGridViewProductList.CurrentRow.Cells[0].Value;
            Quantity = int.Parse(this.cbxQuantity.Text);

            // 假如購物車內已有同種商品, 則增加購買數量
            foreach(var cartitem in this.dbContext.ShoppingCarts)
            {
                if (cartitem.ProductID == PID)
                {
                   cartitem.Quantity += Quantity;
                    MessageBox.Show($"購物車內商品: {cartitem.Product.ProductName}\n已增加購買數量: {Quantity}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.RefreshCart();
                   this.RefreshCartInfo();
                   return;
                }
            }

            ShoppingCart shoppingcart = new ShoppingCart { MemberID = MemberUtility.MemberID, ProductID = PID, Quantity = Quantity };
            this.dbContext.ShoppingCarts.Add(shoppingcart);
            this.dbContext.SaveChanges();
            this.RefreshCartInfo();
        }

        // 清空購物車方法
        public void ClearCart()
        {
            var shoppingcart = this.dbContext.ShoppingCarts.ToList();

            if (shoppingcart == null) return;

            this.dbContext.ShoppingCarts.RemoveRange(shoppingcart);
            this.dbContext.SaveChanges();
        }

        // 刪除購物車指定商品
        public void DeleteCartItem()
        {
            if (this.dataGridViewShoppingCart.CurrentRow == null) return;

            int CartID = (int)this.dataGridViewShoppingCart.CurrentRow.Cells[0].Value;

            var deleteitem = ( from p in this.dbContext.ShoppingCarts
                                             where p.ShoppingCartID == CartID
                                             select p ).FirstOrDefault();

            if (deleteitem == null) return;

            this.dbContext.ShoppingCarts.Remove(deleteitem);
            this.dbContext.SaveChanges();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            this.DeleteCartItem();
            this.RefreshCart();
        }

        // 結帳
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string phone = this.txtOrderPhone.Text;
            bool phonecheck = Regex.IsMatch(phone, @"^09[0-9]{8}$");
     
            if (this.dataGridViewShoppingCart.Rows.Count == 0)
            {
                MessageBox.Show("購物車無商品, 無法結帳", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("請問是否結帳商品", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ) 
            {
                // 結帳選項
                if (deliveryTypeID == 0 || paymentTypeID == 0 || transactionTypeID == 0)
                {
                    MessageBox.Show("尚有結帳選項未選擇, 請選擇", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 訂購資料
                if (txtOrderName.Text == string.Empty || txtOrderPhone.Text == string.Empty || txtOrderAddress.Text == string.Empty)
                {
                    MessageBox.Show("訂購資料尚有缺少,請填寫必要資訊", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!phonecheck)
                {
                    MessageBox.Show("電話格式不正確, 請重新輸入");
                    return;
                }

                // 購物車內有任一商品種類庫存不足時, 取消結帳
                foreach (var cartitem in this.dbContext.ShoppingCarts)
                {
                  if(cartitem.Product.UnitsInStock <= 0)
                    {
                        MessageBox.Show($"購物車內商品: {cartitem.Product.ProductName}\n目前已完售, 請重新結帳 !!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                this.SubtractUnitsInStock();
                this.AddOrder();
                this.AddOrderDetail();
                this.ClearCart();
                this.RefreshCart();
                this.ResetCartInfo();
                this.Product_Load();
                MessageBox.Show("購買訂單及明細已成立");
            }
            else
            {
                MessageBox.Show("結帳已取消");
                return;
            }
        }

        // 新增訂單方法
        public void AddOrder()
        {
            // 預設訂單狀態為 未付款
            int orderstatusid = 1;

            Order order = new Order
            {
                MemberID = MemberUtility.MemberID,
                DeliveryTypeID = deliveryTypeID,
                PaymentTypeID = paymentTypeID,
                TransactionTypeID = transactionTypeID,
                OrderStatusID = orderstatusid,
                RequiredDate = DateTime.Now,
                ShippedTo = txtOrderAddress.Text,
                Frieght = 60,
                OrderName = txtOrderName.Text,
                OrderPhone = txtOrderPhone.Text
            };
            this.dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();
        }

        // 新增訂單明細方法
        public void AddOrderDetail()
        {
            int orderid = GetLastOrderID();

            for (int i = 0; i< this.dataGridViewShoppingCart.Rows.Count; i++)
            {
                string currency = this.dataGridViewShoppingCart.Rows[i].Cells[3].Value.ToString();
                decimal unitpirce = Decimal.Parse(currency, NumberStyles.Currency);

                OrderDetail orderdetail = new OrderDetail
                {
                    OrderID = orderid,
                    ProductID = (int)this.dataGridViewShoppingCart.Rows[i].Cells[1].Value,
                    UnitPrice = unitpirce,
                    Quantity = (int)this.dataGridViewShoppingCart.Rows[i].Cells[4].Value,
                    Commented = false
                };
                this.dbContext.OrderDetails.Add(orderdetail);
                this.dbContext.SaveChanges();
            }
        }

        // 取得運送方式 TypeID
        public int GetDeliveryTypeID()
        {
            deliveryTypeID = this.rbtnHomeDelivery.Checked ? 1 : 2;
            return deliveryTypeID;
        }

        // 取得付款方式 TypeID
        public int GetPaymentTypeID()
        {
            paymentTypeID = this.rbtnCashOnDelivery.Checked ? 1 : 2;
            return paymentTypeID;
        }

        // 取得交易模式 TypeID
        public int GetTransactionTypeID()
        {
            transactionTypeID = this.rbtnBuyMode.Checked ? 1 : 2;
            return transactionTypeID;
        }

        // 取得最後一筆訂單編號
        public int GetLastOrderID()
        {
            var LastOrderID = this.dbContext.Orders.AsEnumerable().Select(o => o.OrderID).Last();
            return LastOrderID;
        }

        // 滑鼠雙擊事件 (加入商品至購物車)
        private void dataGridViewProductList_DoubleClick(object sender, EventArgs e)
        {
            int UnitsInStock = (int)this.dataGridViewProductList.CurrentRow.Cells[6].Value;
            if ( UnitsInStock <= 0 )
            {
                MessageBox.Show("此商品已無庫存, 請補貨時再購買", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.AddToCart();
            this.RefreshCart();
        }


        // 扣除商品庫存數量方法
        public void SubtractUnitsInStock()
        {
            foreach (var cartitem in this.dbContext.ShoppingCarts)
            {
                cartitem.Product.UnitsInStock -= cartitem.Quantity;
            }

            this.dbContext.SaveChanges();
        }

        // 刷新購物車方法
        public void RefreshCart()
        {
            this.dataGridViewShoppingCart.DataSource = null;

            var CartItem = from s in this.dbContext.ShoppingCarts.AsEnumerable()
                                       select new
                                       {
                                           項目序號 = s.ShoppingCartID,
                                           商品編號 = s.ProductID,
                                           商品名稱 = s.Product.ProductName,
                                           商品價格 = $"{s.Product.UnitPrice:c0}",
                                           購買數量 = s.Quantity,
                                           項目小計 =$"{s.Product.UnitPrice * s.Quantity:c0}"
                                       };

            this.dataGridViewShoppingCart.DataSource = CartItem.ToList();
        }

        // 刷新購物車資訊方法
        public void RefreshCartInfo()
        {
            var subtotal = this.dbContext.ShoppingCarts.AsEnumerable().Select(sc => sc.Quantity * sc.Product.UnitPrice).Sum();
            var itemcount = this.dbContext.ShoppingCarts.AsEnumerable().Count();

            this.labFreight.Text = $"運費 : NT${ Freight }";
            this.labProductPrice.Text = $"商品金額 : NT${subtotal}";
            this.labTotal.Text = $"總金額 ( {itemcount} 項商品 ) : \nNT${ Freight + subtotal }";
        }

        // 重置購物車資訊方法
        public void ResetCartInfo()
        {
            this.labFreight.Text = "運費 : NT$0";
            this.labProductPrice.Text = "商品金額 : NT$0";
            this.labTotal.Text = "總金額 ( 0 個商品 ) : NT$0";
        }

        // radioButtons 事件
        void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb.Name == "rbtnHomeDelivery" || rb.Name == "rbtnInStorePickup")
                    {
                        this.GetDeliveryTypeID();
                    }
                    else if (rb.Name== "rbtnCashOnDelivery" || rb.Name == "rbtnCreditCard")
                    {
                        this.GetPaymentTypeID();
                    }
                    else if (rb.Name == "rbtnBuyMode" || rb.Name == "rbtnDonateMode")
                    {
                        this.GetTransactionTypeID();
                    }
                }
            }
        }
    }
}