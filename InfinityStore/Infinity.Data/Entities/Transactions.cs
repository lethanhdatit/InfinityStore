using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Transactions
    {
        public long Id { get; set; }
        public string ExternalTransId { get; set; }
        public long PaymentProviderId { get; set; }
        public long OrderId { get; set; }
        public double Amount { get; set; }
        public double Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public byte Status { get; set; }

        public virtual Orders Order { get; set; }
        public virtual PaymentProviders PaymentProvider { get; set; }
    }
}
