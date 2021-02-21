using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Admin.Controllers
{
    public class PagesController : Controller
    {
        private readonly IFixedPagesRepository _fixedPagesRepository;

        public PagesController(IFixedPagesRepository fixedPagesRepository)
        {
            _fixedPagesRepository = fixedPagesRepository;
        }
        public ActionResult Index()
        {
            return View(_fixedPagesRepository.GetAllFixedPages());
        }
        public ActionResult Fixed()
        {
            return View();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Fixed(FixedPages pages)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            if (Request.Files.Count > 0)
            {
                string randomImageName = "-" + Guid.NewGuid() + "-";
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string path = "/Static/Images/Fixed/" + randomImageName + fileName;
                Request.Files[0].SaveAs(Server.MapPath(path));
                pages.ImagePath = path;
            }
            _fixedPagesRepository.AddFixedPage(pages.Title, pages.Description, pages.ImagePath);
            return RedirectToAction("Index", "Pages");
        }
        public ActionResult EditFixed(int Id)
        {
            var fixedPage = _fixedPagesRepository.GetById(Id);
            if (fixedPage == null)
                return RedirectToAction("Fixed", "Pages");
            return View(fixedPage);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFixed(FixedPages pages)
        {
            if (!ModelState.IsValid)
                return HttpNotFound();
            else
            {
                if (Request.Files[0].ContentLength > 0 && Request.Files[0] != null)
                {
                    string randomImageName = Guid.NewGuid() + "-";
                    string fileName = Path.GetFileName(Request.Files[0].FileName);
                    string path = "/Static/Images/Fixed/" + randomImageName + fileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    pages.ImagePath = path;
                }
                _fixedPagesRepository.Update(pages);
            }
            return View(pages);
        }

        [HttpPost]
        public JsonResult DeleteFixed(int Id)
        {
            _fixedPagesRepository.Delete(Id);

            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}