using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDto
    {
        // Returns prop Username and Token when logged in or Register as new user
        public string Username { get; set; }

        public string Token { get; set; }
    }
}