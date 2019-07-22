using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Students.Web.Models;

namespace Students.Web.Controllers
{
    public class UserController : Controller
    {
        private static readonly List<UserViewModel> Users = new List<UserViewModel>
        {
            new UserViewModel { Id = 1, Email = "dan@yahoo.com", UserName = "Dan", Adresa = new Address{ City="Iasi", Street="Nicolina"} },
            new UserViewModel { Id = 2, Email = "andrei@yahoo.com", UserName = "Andrei", Adresa = new Address{ City="Cluj Napoca", Street="Napoca"} },
            new UserViewModel { Id = 3, Email = "vlad@yahoo.com", UserName = "Vlad", Adresa = new Address{ City = "Brasov", Street="Victriei"} },
            new UserViewModel { Id = 4, Email = "lucian@yahoo.com", UserName = "Lucian", Adresa = new Address{ City = "Bucuresti", Street="Ploii"} },
        };

        [HttpGet]
        public ActionResult Index()
        {
            return View(Users);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = Users.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        //public ActionResult AddNew()
        //{
        //    var username = Request.Form["username"];
        //    var email = Request.Form["email"];

        //    var user = new UserViewModel { Email = email, UserName = username, Id = Users.Count + 1 };

        //    Users.Add(user);

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Add(UserViewModel user)
        {
            var count = Users.Count();
            user.Id = count + 1;
            Users.Add(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            //Users.Remove(Users.FirstOrDefault(x => x.Id == id));

            return View(Users.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult Delete()
        {
            var id = Request.Form["Id"];

            Users.Remove(Users.FirstOrDefault(x => x.Id == int.Parse(id)));

            return RedirectToAction("Index");
        }
    }
}

