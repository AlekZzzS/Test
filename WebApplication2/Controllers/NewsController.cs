using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private readonly ApplicationContext dbContext;

        public NewsController(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("GetSources")]
        [Authorize]
        public IActionResult GetSources() 
        {
            var source = dbContext.News.Select(x => x.Source).ToList();
            return Ok(source);
        }

        [HttpPost("GetThemes")]
        [Authorize]
        public IActionResult GetThemes()
        {
            var themes =  dbContext.News.Select(x => x.Theme).ToList();
            return Ok(themes);
        }

        [HttpPost("GetNews")]
        [Authorize]
        public IActionResult GetAllNews()
        {
            var news = dbContext.News.Select(x => x.News).ToList();
            return Ok(news);
        }

        [HttpPost("GetNewsBySource")]
        [Authorize]
        public IActionResult GetNewsBySource(string source)
        {
            var news = dbContext.News.Where(x => x.Source == source).Select(x => x.News).ToList();
            return Ok(news);
        }

    }
}
