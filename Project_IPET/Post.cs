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
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.PosterImagePaths = new HashSet<PosterImagePath>();
            this.PostLikeds = new HashSet<PostLiked>();
            this.PostTags = new HashSet<PostTag>();
        }
    
        public int PostID { get; set; }
        public int MemberID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime PostDate { get; set; }
        public Nullable<int> PosterImagePathID { get; set; }
        public int PostTypeID { get; set; }
        public bool Banned { get; set; }
        public int LikeCount { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual PosterImagePath PosterImagePath { get; set; }
        public virtual PostType PostType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosterImagePath> PosterImagePaths { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostLiked> PostLikeds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
