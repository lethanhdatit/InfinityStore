using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Products
    {
        public Products()
        {
            MerchantStoreProducts = new HashSet<MerchantStoreProducts>();
            ProductCategories = new HashSet<ProductCategories>();
            ProductInstances = new HashSet<ProductInstances>();
            ProductTranslations = new HashSet<ProductTranslations>();
            ProductVariations = new HashSet<ProductVariations>();
        }

        public long Id { get; set; }
        public string Isbn { get; set; }
        public string Sku { get; set; }
        public byte Status { get; set; }
        public double? RatingAvg { get; set; }
        public long? ViewCount { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastModifiedBy { get; set; }

        public virtual ICollection<MerchantStoreProducts> MerchantStoreProducts { get; set; }
        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
        public virtual ICollection<ProductInstances> ProductInstances { get; set; }
        public virtual ICollection<ProductTranslations> ProductTranslations { get; set; }
        public virtual ICollection<ProductVariations> ProductVariations { get; set; }
    }
}
