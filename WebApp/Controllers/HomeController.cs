using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Services.Users;
using NLog;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        protected IUserService UserService { get; private set; }

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public HomeController(IUserService userService)
        {
            this.UserService = userService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ContentResult HelloWorld()
        {
            logger.Info("some logs");
            return Content(UserService.GetHelloWorld());
        }

    }
}
