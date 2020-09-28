using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Options
    {
        public Options()
        {
            OptionTranslations = new HashSet<OptionTranslations>();
            ProductVariations = new HashSet<ProductVariations>();
        }

        public long Id { get; set; }
        public long AttributeId { get; set; }
        public byte Status { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual ICollection<OptionTranslations> OptionTranslations { get; set; }
        public virtual ICollection<ProductVariations> ProductVariations { get; set; }
    }
}
