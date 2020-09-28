using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class CategoryMenu
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
       public List<CategoryMenu> Children { get; set; }
    }
}
