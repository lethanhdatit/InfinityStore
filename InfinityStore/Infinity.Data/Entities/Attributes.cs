using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Attributes
    {
        public Attributes()
        {
            AttributeTranslations = new HashSet<AttributeTranslations>();
            CategoryAttributes = new HashSet<CategoryAttributes>();
            Options = new HashSet<Options>();
            ProductVariations = new HashSet<ProductVariations>();
        }

        public long Id { get; set; }
        public bool IsDesc { get; set; }
        public byte Status { get; set; }

        public virtual ICollection<AttributeTranslations> AttributeTranslations { get; set; }
        public virtual ICollection<CategoryAttributes> CategoryAttributes { get; set; }
        public virtual ICollection<Options> Options { get; set; }
        public virtual ICollection<ProductVariations> ProductVariations { get; set; }
    }
}
