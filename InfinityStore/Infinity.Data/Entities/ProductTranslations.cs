using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class ProductTranslations
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public string Keyword { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public string SeoAlias { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastModifiedBy { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Products Product { get; set; }
    }
}
