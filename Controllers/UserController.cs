using BeeteeManagement.Data;
using BeeteeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeeteeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context ;
        public UserController(DataContext context)
        {
            _context = context;
        }

        //[HttpGet("Users")]
        //public async Task<IActionResult<List<EmployeeRequest>>> Get()
        //{
        // //   return await Ok();
        //}
        
    }
}
