using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISettingsRepository _settingsRepository;

        public HomeController(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository; 
        }
        public ActionResult Index()
        {
            var setting = _settingsRepository.GetById(1);
            return View(setting); 
        }
       
        [System.Web.Mvc.HttpPost]
        public ActionResult Index(Settings settings)
        {
            _settingsRepository.Update(settings);
            return View(settings);
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