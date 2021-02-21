using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Core.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
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