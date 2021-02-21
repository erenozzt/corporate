using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwwKurumsal.Core.Interfaces;

namespace wwwKurumsal.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersRepository _usersRepository;

        public HomeController(IUsersRepository usersRepository) 
        {
            _usersRepository = usersRepository;
        }
        public HomeController()
        {

        }
        public ActionResult Index()
        { 
            return View(_usersRepository.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}