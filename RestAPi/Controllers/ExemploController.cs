using Microsoft.AspNetCore.Mvc;

namespace RestAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExemploController : ControllerBase
    {
        
        [HttpGet("returnIdade")]
        public int returnIdade()
        {
            return 23;            
        }

        [HttpGet("returnNome")]
        public string ReturnNome()
        {
            return "Victor";
        }
    }
}
