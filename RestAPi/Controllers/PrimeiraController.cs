using Microsoft.AspNetCore.Mvc;

namespace RestAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeiraController : ControllerBase
    {
        [HttpGet("primeiro")]
        public string primeiroEndPoint()
        {
            return "Aula RestAPI";
        }

       

    }
}
