using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Languages
    {
        public Languages()
        {
            AttributeTranslations = new HashSet<AttributeTranslations>();
            CategoryTranslations = new HashSet<CategoryTranslations>();
            OptionTranslations = new HashSet<OptionTranslations>();
            PaymentProviderTranslations = new HashSet<PaymentProviderTranslations>();
            ProductTranslations = new HashSet<ProductTranslations>();
            ShippingProviderTranslations = new HashSet<ShippingProviderTranslations>();
        }

        public long Id { get; set; }
        public string TwoLetterIso { get; set; }
        public string ThreeLetterIso { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string NativeName { get; set; }
        public string EnglishName { get; set; }
        public byte Status { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<AttributeTranslations> AttributeTranslations { get; set; }
        public virtual ICollection<CategoryTranslations> CategoryTranslations { get; set; }
        public virtual ICollection<OptionTranslations> OptionTranslations { get; set; }
        public virtual ICollection<PaymentProviderTranslations> PaymentProviderTranslations { get; set; }
        public virtual ICollection<ProductTranslations> ProductTranslations { get; set; }
        public virtual ICollection<ShippingProviderTranslations> ShippingProviderTranslations { get; set; }
    }
}
