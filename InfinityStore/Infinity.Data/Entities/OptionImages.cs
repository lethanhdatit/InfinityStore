using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class OptionImages
    {
        public long Id { get; set; }
        public long OptionTranslationId { get; set; }
        public string ImgUrl { get; set; }
        public byte Status { get; set; }

        public virtual OptionTranslations OptionTranslation { get; set; }
    }
}
