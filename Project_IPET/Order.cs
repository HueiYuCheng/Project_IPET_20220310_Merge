//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_IPET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.DonationDetails = new HashSet<DonationDetail>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public int DeliveryTypeID { get; set; }
        public int PaymentTypeID { get; set; }
        public int TransactionTypeID { get; set; }
        public int OrderStatusID { get; set; }
        public Nullable<int> CouponID { get; set; }
        public System.DateTime RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public string ShippedTo { get; set; }
        public decimal Frieght { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string OrderName { get; set; }
        public string OrderPhone { get; set; }
    
        public virtual Coupon Coupon { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonationDetail> DonationDetails { get; set; }
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual OrderStatu OrderStatu { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
