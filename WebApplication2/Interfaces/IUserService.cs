using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Interfaces
{
    public interface IUserService
    {
        bool IsValid(LoginModel model);
    }
}
