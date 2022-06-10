
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
    public class HrDataController : ControllerBase
    {
        private readonly DataContext _context;
        public HrDataController(DataContext context)
        {
            _context = context;
        }

        private static List<HrDataRequest> Users = new List<HrDataRequest>
            {
                new HrDataRequest
                {
                Id = 1,
                Payroll = 5233,
                SocSecureNumber ="adfavd",
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<HrDataRequest>>> Get()
        {
            return Ok(await _context.HrDatas.ToListAsync());
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<HrDataRequest>> Get(int id)
        {
            var employee = await _context.HrDatas.FindAsync(id);
            if (employee == null)
                return BadRequest("Not found");
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<HrDataRequest>>> AddUsers([FromBody] HrDataRequest employee)
        {
            _context.HrDatas.Add(employee);
            await _context.SaveChangesAsync();

            return Ok(await _context.HrDatas.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<HrDataRequest>>> UpdateUsers(HrDataRequest request)
        {
            var employee = Users.Find(h => h.Id == request.Id);
            if (employee == null)
                return BadRequest("Not found");

            //--
            return Ok(Users);
        }


        [HttpDelete("(id)")]
        public async Task<ActionResult<List<HrDataRequest>>> Delete(int id)
        {
            var employee = Users.Find(h => h.Id == id);
            if (employee == null)
                return BadRequest("Not found");
            Users.Remove(employee);
            return Ok(Users);
        }

    }
}

