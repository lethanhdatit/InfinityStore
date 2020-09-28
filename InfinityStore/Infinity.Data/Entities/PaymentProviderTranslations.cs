using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class PaymentProviderTranslations
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long PaymentProviderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public byte Status { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PaymentProviders PaymentProvider { get; set; }
    }
}
