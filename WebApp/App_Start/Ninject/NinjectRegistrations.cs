using Ninject.Modules;

namespace WebApp
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<EF.DataPersistance.IUnitOfWork>().To<EF.DataPersistance.UnitOfWork>();

            Bind<Services.Users.IUserService>().To<Services.Users.UserService>().InSingletonScope();
        }
    }
}