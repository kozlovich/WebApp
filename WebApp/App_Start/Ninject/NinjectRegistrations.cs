using Ninject.Modules;

namespace WebApp
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<Services.Users.IUserService>().To<Services.Users.UserService>().InSingletonScope();
        }
    }
}