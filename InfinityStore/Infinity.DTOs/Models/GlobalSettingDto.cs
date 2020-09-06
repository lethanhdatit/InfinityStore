using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infinity.DTOs
{
    public class GlobalSettingDto
    {
        public long ID { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Value { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public byte Status { get; set; }
    }
}
