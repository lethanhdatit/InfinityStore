using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class CategoryNode
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string SeoUrl { get; set; }
        public List<CategoryNode> Children { get; set; }
    }
}
