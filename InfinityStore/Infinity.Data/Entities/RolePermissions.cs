using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class RolePermissions
    {
        public long Id { get; set; }
        public string RoleId { get; set; }
        public string Permissions { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
