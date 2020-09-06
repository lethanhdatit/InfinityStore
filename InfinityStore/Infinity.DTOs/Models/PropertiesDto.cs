using System;
using System.Collections.Generic;

namespace Infinity.DTOs
{
    public partial class PropertiesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public byte Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastUpdatedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastUpdatedBy { get; set; }
        public byte Type { get; set; }

        public virtual ICollection<ProductPropertiesDto> ProductProperties { get; set; }
    }
}
