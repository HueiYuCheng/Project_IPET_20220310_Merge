using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IPET
{
    public partial class FrmOrder_Back : Form
    {
        public FrmOrder_Back()
        {
            InitializeComponent();
            LoadComboboxmember();
            LoadStatus();
            LoadProductCombo();
            this.numericUpDown1.Minimum = 1;
        }
        MyProjectEntities dbContext = new MyProjectEntities();
        int OrderID;
        //會員COMBOBOX
        public void LoadComboboxmember()
        {
            var q = from m in dbContext.Members
                    select m.MemberID;
            this.comboBox1.Items.Clear();
            foreach (var item in q)
            {
                this.comboBox1.Items.Add(item);
            }
        }
        //狀態COMBO
        public void LoadStatus()
        {
            var q = from s in dbContext.OrderStatus
                    select s.OrderStatusName;
            this.comboBox2.Items.Clear();
            this.comboBox3.Items.Clear();
            foreach (var item in q)
            {
                this.comboBox2.Items.Add(item);
                this.comboBox3.Items.Add(item);
            }
        }

        //所有訂單
        private void button1_Click(object sender, EventArgs e)
        {
            var q = from o in dbContext.Orders
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        運費 = o.Frieght,
                        訂單金額 = o.OrderDetails.Sum(p=>p.Quantity * p.UnitPrice),
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //根據會員ID
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == string.Empty) return;
            var q = from o in dbContext.Orders.AsEnumerable()
                    .Where(o => o.MemberID == int.Parse(this.comboBox1.Text))
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        運費 = o.Frieght,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice) + o.Frieght,
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //根據日期
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime thisdate = new DateTime(this.dateTimePicker2.Value.Year, this.dateTimePicker2.Value.Month, this.dateTimePicker2.Value.Day, 23, 59, 59);

            var q = from o in dbContext.Orders
                    .Where(o=>o.RequiredDate >= this.dateTimePicker1.Value.Date && o.RequiredDate <= thisdate)
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        運費 = o.Frieght,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice) + o.Frieght,
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //根據訂單狀態
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == null) return;
            var q = from o in dbContext.Orders
                    .Where(o => o.OrderStatu.OrderStatusName == this.comboBox2.Text)
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        運費 = o.Frieght,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice) + o.Frieght,
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //改變訂單總覽選項時 && 顯示訂單明細
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource1.Current == null)
            {
                this.dataGridView2.DataSource = null;
                return;
            }
            OrderID = ((dynamic)this.bindingSource1.Current).訂單編號;
            this.textBox1.Text = OrderID.ToString();
            this.textBox2.Text = OrderID.ToString();
            this.textBox4.Text = OrderID.ToString();

            //訂單明細
            var q = from o in dbContext.OrderDetails
                    .Where(o => o.OrderID == OrderID)
                    select new
                    {
                        明細編號 = o.OrderDetailID,
                        訂單編號 = o.OrderID,
                        商品名稱 = o.Product.ProductName,
                        商品價格 = o.UnitPrice,
                        商品數量 = o.Quantity,
                        商品總價 = o.UnitPrice * o.Quantity
                    };
            this.bindingSource2.DataSource = q.ToList();
            this.dataGridView2.DataSource = this.bindingSource2;
            LoadDetailCombo();
        }

        //訂單細節之商品ComboBox
        public void LoadDetailCombo()
        {
            var q = from o in dbContext.OrderDetails
                    .Where(o => o.OrderID == OrderID)
                    select o.Product.ProductName;
            this.comboBox4.Text = "";
            this.comboBox4.Items.Clear();
            foreach (var item in q)
            {
                this.comboBox4.Items.Add(item);
            }
        }

        //更新資料顯示
        void Read_RefreshDataGridView()
        {
            var q = from o in dbContext.Orders
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        運費 = o.Frieght,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice) + o.Frieght,
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //=================================
        //修改

        //更改當前選擇訂單之訂單狀態
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("確定修改?","修改訂單狀態",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var q = (from o in dbContext.Orders.AsEnumerable()
                        .Where(o => o.OrderID == int.Parse(this.textBox1.Text))
                             select o).FirstOrDefault();
                    if (q == null) return;
                    q.OrderStatusID = int.Parse(this.comboBox3.Text);
                    this.dbContext.SaveChanges();
                    Read_RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //更改當前選擇訂單之運送地址
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("確定修改?","修改訂單運送地址",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var q = (from o in dbContext.Orders.AsEnumerable()
                        .Where(o => o.OrderID == int.Parse(this.textBox2.Text))
                             select o).FirstOrDefault();
                    if (q == null) return;
                    q.ShippedTo = this.textBox3.Text;
                    this.dbContext.SaveChanges();
                    Read_RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=================================
        //刪除

        //刪除當前選擇之訂單 (刪除訂單明細)
        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text == string.Empty) return;

            if (MessageBox.Show("確定刪除?", "刪除訂單", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //將商品數量導回庫存
                var q3 = from o in dbContext.OrderDetails.AsEnumerable()
                     .Where(o => o.OrderID == int.Parse(this.textBox4.Text))
                         select new { o, o.ProductID, o.Quantity };
                if (q3 == null) return;
                foreach (var item in q3)
                {
                    var q4 = (from p in dbContext.Products.AsEnumerable()
                             .Where(o => o.ProductID == item.ProductID)
                              select p).FirstOrDefault();
                    if (q4 == null) return;
                    q4.UnitsInStock += item.Quantity;
                    this.dbContext.OrderDetails.Remove(item.o);
                }

                //刪除訂單
                var q = (from o in dbContext.Orders.AsEnumerable()
                        .Where(o => o.OrderID == int.Parse(this.textBox4.Text))
                         select o).FirstOrDefault();
                if (q == null) return;
                this.dbContext.Orders.Remove(q);
                this.dbContext.SaveChanges();
                Read_RefreshDataGridView();
            }
        }

        //刪除當前選擇之訂單明細
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textBox5.Text == string.Empty) return;
            if (MessageBox.Show("確定刪除此商品明細?", "刪除訂單明細", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //當前明細
                var q = (from o in dbContext.OrderDetails.AsEnumerable()
                        .Where(o => o.OrderDetailID == int.Parse(this.textBox5.Text))
                         select o).FirstOrDefault();

                //當前明細之數量歸回商品當中
                var q1 = (from p in dbContext.Products
                         .Where(p => p.ProductName == q.Product.ProductName)
                          select p).FirstOrDefault();
                if (q1 == null) return;
                if (q == null) return;
                q1.UnitsInStock += q.Quantity;
                this.dbContext.OrderDetails.Remove(q);
                this.dbContext.SaveChanges();
                Read_RefreshDataGridView();
                Read_RefreshDataGridViewDeatil();
            }
        }

        //=================================
        //修改訂單明細

        // 修改訂單明細中所選定之商品數量
        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定修改此訂單商品明細?","修改訂單明細",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                //當前商品明細
                var q = (from o in dbContext.OrderDetails
                    .Where(o => o.Product.ProductName == this.comboBox4.Text && o.OrderID == OrderID)
                         select o).FirstOrDefault();

                //當前商品庫存
                var q1 = (from p in dbContext.Products
                         .Where(p => p.ProductName == this.comboBox4.Text)
                          select p).FirstOrDefault();

                if (q == null) return;
                if (q1 == null) return;

                //庫存減少
                q1.UnitsInStock -= ((int)this.numericUpDown1.Value - q.Quantity);
                //明細數量增加
                q.Quantity = (int)this.numericUpDown1.Value;
                this.dbContext.SaveChanges();
                Read_RefreshDataGridView();
                Read_RefreshDataGridViewDeatil();
            }
        }

        //訂單明細選取改變時
        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            string DetailProduct = ((dynamic)this.bindingSource2.Current).商品名稱;
            this.comboBox4.Text = DetailProduct;
            var q = (from p in dbContext.Products
                     .Where(p => p.ProductName == this.comboBox4.Text)
                     select p.UnitsInStock).FirstOrDefault();
            int DetailQuantity = ((dynamic)this.bindingSource2.Current).商品數量;
            this.numericUpDown1.Maximum = q + DetailQuantity;
            this.numericUpDown1.Value = DetailQuantity;
            int DetailID = ((dynamic)this.bindingSource2.Current).明細編號;
            this.textBox5.Text = DetailID.ToString();
        }

        //重新整理訂單明細
        public void Read_RefreshDataGridViewDeatil()
        {
            var q = from o in dbContext.OrderDetails
                    .Where(o => o.OrderID == OrderID)
                    select new
                    {
                        明細編號 = o.OrderDetailID,
                        訂單編號 = o.OrderID,
                        商品名稱 = o.Product.ProductName,
                        商品價格 = o.UnitPrice,
                        商品數量 = o.Quantity,
                        商品總價 = o.UnitPrice * o.Quantity
                    };

            this.bindingSource2.DataSource = q.ToList();
            this.dataGridView2.DataSource = this.bindingSource2;
            LoadDetailCombo();
        }

        //新增商品至當前訂單
        private void button10_Click(object sender, EventArgs e)
        {
            //當前選擇商品之價格
            var q = (from p in dbContext.Products.AsEnumerable()
                     where (p.ProductName == this.comboBox5.Text)
                     select p.UnitPrice).FirstOrDefault();

            //當前選擇商品之商品ID
            var q1 = (from p in dbContext.Products.AsEnumerable()
                     where (p.ProductName == this.comboBox5.Text)
                     select p.ProductID).FirstOrDefault();

            //新增至訂單明細中
            OrderDetail orderDetail = new OrderDetail
            {
                OrderID = OrderID,
                ProductID = q1,
                UnitPrice = q,
                Quantity = (int)this.numericUpDown2.Value,
                Commented = false
            };
            this.dbContext.OrderDetails.Add(orderDetail);

            //更改當前選擇之商品之庫存
            var q2 = (from p in dbContext.Products
                     .Where(p => p.ProductID == q1)
                      select p).FirstOrDefault();
            if (q2 == null) return;
            q2.UnitsInStock = q2.UnitsInStock - (int)this.numericUpDown2.Value;

            this.dbContext.SaveChanges();
            Read_RefreshDataGridView();
            Read_RefreshDataGridViewDeatil();
        }

        //商品總覽ComboBox
        public void LoadProductCombo()
        {
            var q = from p in dbContext.Products
                    .Where(p=>p.UnitsInStock > 0)
                    orderby p.ProductID ascending
                    select p.ProductName;
            this.comboBox5.Items.Clear();
            foreach (var item in q)
            {
                this.comboBox5.Items.Add(item);
            }
        }

        //根據商品更訂數量可選擇最大值
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = (from p in dbContext.Products
                    .Where(p => p.ProductName == this.comboBox5.Text)
                     select p.UnitsInStock).FirstOrDefault();
            this.numericUpDown2.Maximum = q;
            this.numericUpDown2.Minimum = 1;
        }
    }
}