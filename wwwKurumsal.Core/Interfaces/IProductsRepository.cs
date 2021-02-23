using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwwKurumsal.Data.DbModel;
using wwwKurumsal.Data.ViewModel;

namespace wwwKurumsal.Core.Interfaces
{
    public interface IProductsRepository : IRepository<Products>
    {
        int InsertProduct(Products obj);
        List<ProductCategoryViewModel> GetAllProducts();
    }
}
