using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data;

namespace wwwKurumsal.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsersRepository _usersRepository;

        public LoginController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(Users user)
        {
            var _user = _usersRepository.GetUser(user.Email,user.Password,true);
            if (_user ==null)
            {
                user.LoginErrorMessage = "Hatalı Kullanıcı Adı Veya Şifre";
                return View("Index", user);
            }
            else
            {
                Session["UserId"] = _user.Id;
                Session["UserName"] = _user.Email; 
                return RedirectToAction("Index", "Home");
            } 
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}