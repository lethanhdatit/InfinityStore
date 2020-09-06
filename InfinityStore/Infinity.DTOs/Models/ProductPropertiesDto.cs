using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class ProductPropertiesDto
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

        public virtual PropertiesDto CustomProperty { get; set; }
        public virtual ProductsDto Product { get; set; }
        public virtual ProductInstancesDto ProductInstance { get; set; }
    }
}
