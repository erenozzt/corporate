using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wwwKurumsal.Data.DbModel
{
    public class Categories
    {
        public Categories()
        {
            this.Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}