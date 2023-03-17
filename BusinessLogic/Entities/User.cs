using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User : IdentityUser
    {
        public DateTime Birthday { get; set; }
        public string? Photo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
