using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class MerchantStores
    {
        public MerchantStores()
        {
            MerchantStoreProducts = new HashSet<MerchantStoreProducts>();
            Warehouses = new HashSet<Warehouses>();
        }

        public long Id { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Hotline { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastModifiedBy { get; set; }

        public virtual ICollection<MerchantStoreProducts> MerchantStoreProducts { get; set; }
        public virtual ICollection<Warehouses> Warehouses { get; set; }
        public virtual AspNetUsers Owner { get; set; }
    }
}
