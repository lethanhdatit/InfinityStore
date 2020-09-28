using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class MerchantStoreProducts
    {
        public long Id { get; set; }
        public long MerchantStoreId { get; set; }
        public long ProductId { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastModifiedBy { get; set; }

        public virtual MerchantStores MerchantStore { get; set; }
        public virtual Products Product { get; set; }
    }
}
