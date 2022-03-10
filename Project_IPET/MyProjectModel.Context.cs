﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyProjectEntities : DbContext
    {
        public MyProjectEntities()
            : base("name=MyProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentImagePath> CommentImagePaths { get; set; }
        public virtual DbSet<CommentReply> CommentReplies { get; set; }
        public virtual DbSet<CouponDetail> CouponDetails { get; set; }
        public virtual DbSet<CouponDiscountType> CouponDiscountTypes { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<DeliveryType> DeliveryTypes { get; set; }
        public virtual DbSet<DonationDetail> DonationDetails { get; set; }
        public virtual DbSet<FavoriteType> FavoriteTypes { get; set; }
        public virtual DbSet<Foundation> Foundations { get; set; }
        public virtual DbSet<MemberRole> MemberRoles { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MyFavorite> MyFavorites { get; set; }
        public virtual DbSet<Notify> Notifies { get; set; }
        public virtual DbSet<NotifiesType> NotifiesTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<PetImagePath> PetImagePaths { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PosterImagePath> PosterImagePaths { get; set; }
        public virtual DbSet<PostLiked> PostLikeds { get; set; }
        public virtual DbSet<PostTag> PostTags { get; set; }
        public virtual DbSet<PostType> PostTypes { get; set; }
        public virtual DbSet<ProductImagePath> ProductImagePaths { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
    }
}