using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductWarehouses
    {
        public long Id { get; set; }
        public long ProductInstanceId { get; set; }
        public long WarehouseId { get; set; }
        public int QuantityStock { get; set; }
        public long ImportPrice { get; set; }

        public virtual ProductInstances ProductInstance { get; set; }
        public virtual Warehouses Warehouse { get; set; }
    }
}
