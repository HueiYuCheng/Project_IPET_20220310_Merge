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
    public partial class FrmOrder_Front : Form
    {
        public FrmOrder_Front()
        {
            InitializeComponent();
            LoadComboBox();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        int Order_MemberID = MemberUtility.MemberID;

        MyProjectEntities dbContext = new MyProjectEntities();

        public void LoadComboBox()
        {
            var q = from s in dbContext.OrderStatus
                    select s.OrderStatusName;
            foreach (var item in q)
            {
                this.comboBox1.Items.Add(item);
            }
        }

        //全部訂單
        private void button1_Click(object sender, EventArgs e)
        {
            var q = from o in dbContext.Orders
                    where o.MemberID == Order_MemberID
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice),
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //依據日期
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime thisdate = new DateTime(this.dateTimePicker2.Value.Year, this.dateTimePicker2.Value.Month, this.dateTimePicker2.Value.Day, 23, 59, 59);

            var q = from o in dbContext.Orders
                    where o.MemberID == Order_MemberID && o.RequiredDate >= this.dateTimePicker1.Value.Date && o.RequiredDate <= thisdate
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice),
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        //依據訂單狀態
        private void button3_Click(object sender, EventArgs e)
        {
            var q = from o in dbContext.Orders
                    where o.MemberID == Order_MemberID && o.OrderStatu.OrderStatusName == this.comboBox1.Text
                    select new
                    {
                        訂單編號 = o.OrderID,
                        會員編號 = o.MemberID,
                        會員名稱 = o.Member.Name,
                        出貨方式 = o.DeliveryType.DeliveryTypeName,
                        付款方式 = o.PaymentType.PaymentTypeName,
                        交易型態 = o.TransactionType.TransactionTypeName,
                        訂單狀態 = o.OrderStatu.OrderStatusName,
                        訂單金額 = o.OrderDetails.Sum(p => p.Quantity * p.UnitPrice),
                        下單時間 = o.RequiredDate,
                        運送地址 = o.ShippedTo,
                        收件人名稱 = o.OrderName,
                        收件人電話 = o.OrderPhone
                    };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource1.Current == null)
            {
                this.dataGridView2.DataSource = null;
                return;
            }
            int OrderID = ((dynamic)this.bindingSource1.Current).訂單編號;

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
            this.dataGridView2.DataSource = q.ToList();
        }
    }
}
