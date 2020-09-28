using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductVariations
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long OptionId { get; set; }
        public long ProductInstanceId { get; set; }
        public long AttributeId { get; set; }
        public byte Status { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual Options Option { get; set; }
        public virtual Products Product { get; set; }
        public virtual ProductInstances ProductInstance { get; set; }
    }
}
