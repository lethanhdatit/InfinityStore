using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class CategoryAttributes
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long AttributeId { get; set; }
        public byte Status { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual Categories Category { get; set; }
    }
}
