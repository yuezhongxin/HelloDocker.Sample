using System.Linq;
using System.Threading.Tasks;
using HelloDocker.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelloDocker.Web.Controllers
{
    [Route(Program.ServiceName + "/" + Program.Version)]
    public class BlogsController : Controller
    {
        private BlogDbContext _dbContext;

        public BlogsController(BlogDbContext dbContext) => _dbContext = dbContext;

        [Route("hell-docker.get")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var form = await _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefaultAsync();
            return Ok(new { form = form });
        }
    }
}
