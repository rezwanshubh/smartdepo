using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SmartDepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        [Route("save")]
        public void Insert()
        {
            
        }
    }
}