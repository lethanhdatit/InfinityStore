using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class ProductInstancesDto
    {
        public long Id { get; set; }
        public long Stock { get; set; }
        public long ProductId { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }

        public virtual ICollection<ProductPropertiesDto> ProductProperties { get; set; }
    }
}
