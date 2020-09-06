using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infinity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        [Required]
        public string FName { get; set; }
        [MaxLength(50)]
        public string MName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LName { get; set; }
        [Required]
        public bool Gender { get; set; }
        public string AvatarUrl { get; set; }
    }
}
