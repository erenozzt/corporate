using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ICategoriesRepository _categoriesRepository;

        public ProductsController(IProductsRepository productsRepository, ICategoriesRepository categoriesRepository)
        {
            _productsRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
        }
        public ActionResult Index()
        {
            var allProducts = _productsRepository.GetAllProducts(); 
            return View(allProducts);
        }
        public ActionResult CreateProduct()
        {
            ViewBag.Categories = _categoriesRepository.GetAllCategories().Select(s=>new SelectListItem() { Value = s.Id.ToString(), Text = s.Name });
            return View();
        }

        [HttpPost] 
        public ActionResult CreateProduct(Products obj)
        {
            if (!ModelState.IsValid)
                return HttpNotFound();
            _productsRepository.InsertProduct(obj); 
            return RedirectToAction("CreateProduct");
        }
    }
}