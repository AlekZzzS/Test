using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Interfaces
{
    public interface IPostRepository
    {
        List<NewsModel> GetNews();
    }
}
