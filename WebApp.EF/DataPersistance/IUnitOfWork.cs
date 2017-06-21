using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.EF.Entries.Users;

namespace WebApp.EF.DataPersistance
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        Repository<User> UsersRepository { get; }
    }
}
