using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class CategoriesDto
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }

        public virtual CategoriesDto Parent { get; set; }
        public virtual ICollection<CategoriesDto> InverseParent { get; set; }
        public virtual ICollection<ProductsDto> Products { get; set; }
    }
}
