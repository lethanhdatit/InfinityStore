using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Categories
    {
        public Categories()
        {
            CategoryAttributes = new HashSet<CategoryAttributes>();
            CategoryTranslations = new HashSet<CategoryTranslations>();
            InverseParent = new HashSet<Categories>();
            ProductCategories = new HashSet<ProductCategories>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long SortOrder { get; set; }
        public byte Status { get; set; }

        public virtual Categories Parent { get; set; }
        public virtual ICollection<CategoryAttributes> CategoryAttributes { get; set; }
        public virtual ICollection<CategoryTranslations> CategoryTranslations { get; set; }
        public virtual ICollection<Categories> InverseParent { get; set; }
        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
