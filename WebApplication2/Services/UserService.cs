using WebApplication2.Interfaces;

namespace WebApplication2.Services
{
    public class UserService : IUserService
    {
        public bool IsValid(LoginModel model)
        {
            if (model.UserName.Equals("admin") && model.Password.Equals("123456"))
                return true;
            else
                return false;
        }

    }
}
