using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Services.Users;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        protected IUserService UserService { get; private set; }

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
            return Content(UserService.GetHelloWorld());
        }

    }
}
