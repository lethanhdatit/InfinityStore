using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Categories
    {
        public Categories()
        {
            InverseParent = new HashSet<Categories>();
            Products = new HashSet<Products>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }

        public virtual Categories Parent { get; set; }
        public virtual ICollection<Categories> InverseParent { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
