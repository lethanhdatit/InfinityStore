using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class AttributeTranslations
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long AttributeId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public byte Status { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual Languages Language { get; set; }
    }
}
