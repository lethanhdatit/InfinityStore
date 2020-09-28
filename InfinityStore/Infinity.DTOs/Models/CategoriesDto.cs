using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class CategoriesDto
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long SortOrder { get; set; }
        public byte Status { get; set; }
    }
}
