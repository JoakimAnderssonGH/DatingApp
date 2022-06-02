using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDto
    {
        // Returns Username and Password when logging in
        public string Username { get; set; }
        public string Password { get; set; }
    }
}