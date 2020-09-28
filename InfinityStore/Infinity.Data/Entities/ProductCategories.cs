using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductCategories
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public byte Status { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Products Product { get; set; }
    }
}
