using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    // DTO används för att platta ut eller dölja information.
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}