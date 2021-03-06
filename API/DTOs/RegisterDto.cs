using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    // DTO används för att platta ut eller dölja information.
    public class RegisterDto
    {
        
        [Required] // Validate
        public string Username { get; set; }
        
        [Required] // Validate
        public string Password { get; set; }
    }
}