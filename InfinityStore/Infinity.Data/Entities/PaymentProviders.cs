using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class PaymentProviders
    {
        public PaymentProviders()
        {
            Orders = new HashSet<Orders>();
            PaymentProviderTranslations = new HashSet<PaymentProviderTranslations>();
            Transactions = new HashSet<Transactions>();
        }

        public long Id { get; set; }
        public string ClientKey { get; set; }
        public string SecretKey { get; set; }
        public byte Status { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<PaymentProviderTranslations> PaymentProviderTranslations { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
