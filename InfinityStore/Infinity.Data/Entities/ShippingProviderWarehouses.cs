using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ShippingProviderWarehouses
    {
        public long WarehouseId { get; set; }
        public long ShippingProviderId { get; set; }
        public string ExternalCode { get; set; }
        public string ExternalAddress { get; set; }
        public byte ExternalStatus { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public DateTime CreatedTs { get; set; }

        public virtual ShippingProviders ShippingProvider { get; set; }
        public virtual Warehouses Warehouse { get; set; }
    }
}
