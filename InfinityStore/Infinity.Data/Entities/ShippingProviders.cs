using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ShippingProviders
    {
        public ShippingProviders()
        {
            ShippingMethods = new HashSet<ShippingMethods>();
            ShippingProviderTranslations = new HashSet<ShippingProviderTranslations>();
            ShippingProviderWarehouses = new HashSet<ShippingProviderWarehouses>();
        }

        public long Id { get; set; }
        public string ClientKey { get; set; }
        public string SecretKey { get; set; }
        public byte Status { get; set; }

        public virtual ICollection<ShippingMethods> ShippingMethods { get; set; }
        public virtual ICollection<ShippingProviderTranslations> ShippingProviderTranslations { get; set; }
        public virtual ICollection<ShippingProviderWarehouses> ShippingProviderWarehouses { get; set; }
    }
}
