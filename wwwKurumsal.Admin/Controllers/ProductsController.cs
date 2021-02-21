using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwwKurumsal.Core.Interfaces;

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
            return View();
        }
        public ActionResult CreateProduct()
        {
            ViewBag.Categories = _categoriesRepository.GetAllCategories();
            return View();
        }
    }
}