using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductProperties
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long CustomPropertyId { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }
        public byte Status { get; set; }
        public long? ProductInstanceId { get; set; }

        public virtual Properties CustomProperty { get; set; }
        public virtual Products Product { get; set; }
        public virtual ProductInstances ProductInstance { get; set; }
    }
}
