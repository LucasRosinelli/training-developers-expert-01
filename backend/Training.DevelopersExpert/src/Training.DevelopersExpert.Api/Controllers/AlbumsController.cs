using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Training.DevelopersExpert.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAlbums()
        {
            return await Task.FromResult(Ok(new
            {
                Message = "My first API",
            }));
        }
    }
}
