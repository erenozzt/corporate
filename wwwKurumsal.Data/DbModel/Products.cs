using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wwwKurumsal.Data.DbModel
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual Categories Categories { get; set; }
    }
}