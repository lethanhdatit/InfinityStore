using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class OptionTranslations
    {
        public OptionTranslations()
        {
            OptionImages = new HashSet<OptionImages>();
        }

        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long OptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Options Option { get; set; }
        public virtual ICollection<OptionImages> OptionImages { get; set; }
    }
}
