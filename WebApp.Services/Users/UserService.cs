using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.EF.DataPersistance;
using WebApp.EF.Entries.Users;
using NLog;

namespace WebApp.Services.Users
{
    public class UserService : IUserService
    {
        protected IUnitOfWork UnitOfWork { get; private set; }

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public UserService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public string GetHelloWorld()
        {
            logger.Info("Hello world!");
            return "Hello, World!";
        }

    }
}
