using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductInstances
    {
        public ProductInstances()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ProductVariations = new HashSet<ProductVariations>();
            ProductWarehouses = new HashSet<ProductWarehouses>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public long CurrentPrice { get; set; }
        public long OriginalPrice { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public double? Rating { get; set; }
        public byte Status { get; set; }

        public virtual Products Product { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<ProductVariations> ProductVariations { get; set; }
        public virtual ICollection<ProductWarehouses> ProductWarehouses { get; set; }
    }
}
