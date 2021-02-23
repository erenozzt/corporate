using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wwwKurumsal.Data.DbModel
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
    }
}