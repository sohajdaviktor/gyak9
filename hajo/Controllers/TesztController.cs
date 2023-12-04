using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hajo.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();

            return Ok(pontosIdő);
        }
        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            //nem mukszik
            try
            {
                string nagybetusSzoveg = szoveg.ToUpper();
                return Ok(szoveg.ToUpper());
            }
            catch(Exception ex)
            {
                return BadRequest("Nem jó a bemenő adat!");
            }
            
        }
    }
}
