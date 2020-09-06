using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class ProductsDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }

        public virtual CategoriesDto Category { get; set; }
        public virtual ICollection<ProductPropertiesDto> ProductProperties { get; set; }
    }
}
