using System.Text;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDbService _dbService;

        public DoctorController([FromServices] IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult getDoctors()
        {
            StringBuilder sb = new StringBuilder();
            var tmp = _dbService.getDoctors();
            foreach (string s in tmp)
            {
                sb.Append(s);
                sb.AppendLine();
            }

            return Ok(sb.ToString());
        }

        [HttpPut]
        public IActionResult addDoctor([FromBody]Doctor doctor)
        {
            bool flag = _dbService.addDoctor(doctor);
            if (flag)
            {
                return Accepted();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult modifyDoctor([FromBody] Doctor doctor)
        {
            bool flag = _dbService.modifyDoctor(doctor);
            if (flag)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult deleteDoctor([FromRoute] int id)
        {
            bool flag = _dbService.removeDoctor(id);

            if (flag)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}