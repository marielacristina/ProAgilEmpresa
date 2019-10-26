using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProAgil.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        [Column(TypeName="varchar(150)")]
        public string FullName { get; set; }
        public List<UserRole> Roles { get; set; }
    }
}