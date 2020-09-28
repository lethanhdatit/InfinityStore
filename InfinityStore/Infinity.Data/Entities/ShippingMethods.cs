using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ShippingMethods
    {
        public ShippingMethods()
        {
            Orders = new HashSet<Orders>();
        }

        public long Id { get; set; }
        public long ShippingProviderId { get; set; }
        public byte Status { get; set; }

        public virtual ShippingProviders ShippingProvider { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
