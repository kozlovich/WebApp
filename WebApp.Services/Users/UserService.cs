using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Services.Users
{
    public class UserService : IUserService
    {
        public string GetHelloWorld()
        {
            return "Hello, World!";
        }
    }
}
