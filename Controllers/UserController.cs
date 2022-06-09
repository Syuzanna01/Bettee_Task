using BeeteeManagement.Data;
using BeeteeManagement.Helpers;
using BeeteeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using static BeeteeManagement.Helpers.GenderEnum;
using BeeteeManagement.Data;

namespace BeeteeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        { 
            _context = context;
        }

        private static List<EmployeeRequest> Users = new List<EmployeeRequest>
            {
                new EmployeeRequest
                {
                ID = 1,
                FirstName = "Angelina",
                LastName = "Joly",
                IdentityNumber = "AD3568",
                BirthDate = DateTime.Now,
                ContactNumber = "+89652135684",
                Email = "sfdfarfrf.com",
                 }
            };
        [HttpGet]
        public async Task<ActionResult<List<EmployeeRequest>>> Get()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

         [HttpGet("(id)")]
        public async Task<ActionResult<EmployeeRequest>> Get(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return BadRequest("Not found");
            return Ok(employee);
        }

        //[HttpPost]
        //public async Task<ActionResult<List<EmployeeRequest>>> AddUsers(EmployeeRequest employee)
        //{
        //    _context.Employees.Add(employee);
        //    await _context.SaveChangesAsync();

        //    return Ok(await _context.Employees.ToListAsync());
        //}

        [HttpPost]
        public async Task<ActionResult<List<EmployeeRequest>>> AddUsers(EmployeeRequest employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<EmployeeRequest>>> UpdateUsers(EmployeeRequest request)
        {
            var employee = Users.Find(h => h.ID == request.ID);
            if (employee == null)
                return BadRequest("Not found");

            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.BirthDate = request.BirthDate;
            employee.HrDatas = request.HrDatas;
            employee.IdentityNumber = request.IdentityNumber;
            employee.ContactNumber = request.ContactNumber;
            employee.Gender = request.Gender;
            return Ok(Users);
        }


        [HttpDelete("(id)")]
        public async Task<ActionResult<List<EmployeeRequest>>> Delete(int id)
        {
            var employee = Users.Find(h => h.ID == id);
            if (employee == null)
                return BadRequest("Not found");
            Users.Remove(employee);
            return Ok(Users);
        }

    }
}
