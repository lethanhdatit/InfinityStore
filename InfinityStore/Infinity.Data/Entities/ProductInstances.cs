using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductInstances
    {
        public ProductInstances()
        {
            ProductProperties = new HashSet<ProductProperties>();
        }

        public long Id { get; set; }
        public long Stock { get; set; }
        public long ProductId { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }

        public virtual ICollection<ProductProperties> ProductProperties { get; set; }
    }
}
