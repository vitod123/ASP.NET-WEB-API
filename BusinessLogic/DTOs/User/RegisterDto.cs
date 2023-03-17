using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.User
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string? Photo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
