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

namespace wwwKurumsal.Core.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly SqlConnection con;
        public CategoriesRepository()
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

        public IEnumerable<Categories> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAllCategories()
        {
            return con.Query<Categories>("sp_getAllCategories", commandType: CommandType.StoredProcedure).ToList();
        }

        public Categories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categories> GetMany(Expression<Func<Categories, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Categories obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Categories obj)
        {
            throw new NotImplementedException();
        }
    }
}