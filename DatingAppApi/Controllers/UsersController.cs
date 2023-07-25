using DatingAppApi.Data;
using DatingAppApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppApi.Controllers
{
    [ApiController] //defining that this class is a controller
    [Route("api/[controller]")] // GET /api/users
    public class UsersController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<AppUser>>> GetAllUsers()
        {
            //var users = _context.Users.ToList();
            var users = await _context.Users.ToListAsync();
            

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}