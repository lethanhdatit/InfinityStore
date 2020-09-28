using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class CategoryTranslations
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public byte Status { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Languages Language { get; set; }
    }
}
