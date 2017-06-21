using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.EF.Entries.Users;

namespace WebApp.EF.DataPersistance
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext context;

        public UnitOfWork(DatabaseContext context)
        {
            this.context = context;
        }

        #region Repositories

        private Repository<User> usersRepository { get; set; }
        public Repository<User> UsersRepository
        {
            get
            {
                if (usersRepository == null)
                {
                    usersRepository = new Repository<User>(context);
                }
                return usersRepository;
            }
        }

        #endregion

        public void Commit()
        {
            context.SaveChanges();
        }
        
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
