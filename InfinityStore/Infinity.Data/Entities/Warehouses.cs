using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Warehouses
    {
        public Warehouses()
        {
            ProductWarehouses = new HashSet<ProductWarehouses>();
            ShippingProviderWarehouses = new HashSet<ShippingProviderWarehouses>();
        }

        public long Id { get; set; }
        public long? MerchantId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ManagerName { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Commune { get; set; }
        public bool IsDefault { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public DateTime CreatedTs { get; set; }

        public virtual MerchantStores Merchant { get; set; }
        public virtual ICollection<ProductWarehouses> ProductWarehouses { get; set; }
        public virtual ICollection<ShippingProviderWarehouses> ShippingProviderWarehouses { get; set; }
    }
}
