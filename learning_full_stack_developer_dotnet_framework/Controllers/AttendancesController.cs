using System.Data.OleDb;
using System.Linq;
using System.Web.Http;
using learning_full_stack_developer_dotnet_framework.Dtos;
using learning_full_stack_developer_dotnet_framework.Models;
using Microsoft.AspNet.Identity;

namespace learning_full_stack_developer_dotnet_framework.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();   
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {

            var usrId = User.Identity.GetUserId();
            var exists = _context.Attendances.Any(a => a.AttendeeId == usrId && a.GigId == dto.GigId);

            if (exists)
                return BadRequest("Attendance already exists.");


            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = usrId
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}