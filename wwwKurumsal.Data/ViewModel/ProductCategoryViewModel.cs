using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Data.ViewModel
{
    public class ProductCategoryViewModel:Products
    { 
        public string CategoryName { get; set; } 
    }
}