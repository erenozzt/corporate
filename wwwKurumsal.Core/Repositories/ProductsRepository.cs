using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data.DbModel;
using wwwKurumsal.Data.ViewModel;

namespace wwwKurumsal.Core.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly SqlConnection con;
        public ProductsRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Kurumsal"].ConnectionString);
        }
        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> GetAllProducts()
        {
            return con.Query<ProductCategoryViewModel>("sp_getAllProducts", commandType: CommandType.StoredProcedure).ToList();
        }

        public Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Products> GetMany(Expression<Func<Products, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Products obj)
        {
            throw new NotImplementedException();
        }
        public int InsertProduct(Products obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@Name", obj.ProductName);
            dynamicParameters.Add("@CategoryId", obj.CategoryId);
            return con.ExecuteScalar<int>("sp_insertProduct",  dynamicParameters , commandType: CommandType.StoredProcedure);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Products obj)
        {
            throw new NotImplementedException();
        }
    }
}