using WebApplication2.Data;
using WebApplication2.Interfaces;

namespace WebApplication2.Repositories
{
    public class PostRepository : BaseRepository<NewsModel>, IPostRepository
    {
        public PostRepository(ApplicationContext context) : base(context) { }

        public List<NewsModel> GetNews()
        {
            var news = _context.News.ToList();
            return news;
        }
    }
}
