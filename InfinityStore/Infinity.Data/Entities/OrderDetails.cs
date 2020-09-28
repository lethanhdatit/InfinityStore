using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class OrderDetails
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductInstanceId { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ProductInstances ProductInstance { get; set; }
    }
}
