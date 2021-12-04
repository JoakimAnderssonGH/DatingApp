using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        // Constructor
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        // Endpoint
        // Exempel för hela listan: api/users
        // Använder await med async för att vänta med anrop mot databas        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //var users = _context.Users.ToList();
            //return users;
            return await _context.Users.ToListAsync();
        }

        // Exempel [id] 1--3: api/users/1
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            //var user = _context.Users.Find(id);
            //return user;
            return await _context.Users.FindAsync(id);
        }
    }
}