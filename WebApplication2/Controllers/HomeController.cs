using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using WebApplication2.Data;
using WebApplication2.Interfaces;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;

        public HomeController(ApplicationContext context) : base() 
        {
            _postRepository = new PostRepository(context);
        }

        [HttpGet]
        //[Authorize]
        public IActionResult Index(int page = 1)
        {
            int pageSize = 3;
            var news = _postRepository.GetNews();
            var newsPerPages = news.Skip((page - 1) * pageSize).Take(pageSize);
            var pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = news.Count };
            var newsOnPage = new IndexViewModel { PageInfo = pageInfo, News = newsPerPages };

            
            return View(newsOnPage);
        }
    }
}
