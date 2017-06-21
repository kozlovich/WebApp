using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.EF.DataPersistance;
using WebApp.EF.Entries.Users;

namespace WebApp.Services.Users
{
    public class UserService : IUserService
    {
        protected IUnitOfWork UnitOfWork { get; private set; }

        public UserService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public string GetHelloWorld()
        {
            return "Hello, World!";
        }

    }
}
