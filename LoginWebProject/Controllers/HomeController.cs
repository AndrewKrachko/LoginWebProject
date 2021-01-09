using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using LoginWebProject.Pages;
using LoginWebProject.Interfaces;

namespace LoginWebProject.ControllerS
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("LoginPage");
        }

        [HttpPost]
        public IActionResult AthenticateUser(string userName, string password)
        {
            if (AuthenticateUser(userName, password))
            {
                var cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("userName", userName ?? "", cookieOptions);
                Response.Cookies.Append("password", password ?? "", cookieOptions);

                return Redirect("PrivatePage");
            }

            return Redirect("LoginPage");
        }

        public IActionResult PrivatePage()
        {
            return View(new PrivatePageModel());
        }

        private bool AuthenticateUser(string user, string password)
        {
            var db = new DataContext("Server=localhost;Database=ItAcademyWebShop;User Id=sa;Password=1234;");

            var isPresented = (from dbUser in db.GetTable<DbUser>()
                              select dbUser.Name == user && dbUser.Password == password).First();

            return isPresented;
        }

        private int GetMinInt(IEnumerable<int> array) => array.Min();

        private int GetMaxInt(IEnumerable<int> array) => array.Max();
    }
}
