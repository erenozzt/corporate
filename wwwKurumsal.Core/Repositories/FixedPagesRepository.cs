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
    public class FixedPagesRepository : IFixedPagesRepository
    {
        private readonly SqlConnection con;
        public FixedPagesRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Kurumsal"].ConnectionString);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            con.Query("sp_DeleteFixedPage", new { Id }, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<FixedPages> GetAll()
        {
            throw new NotImplementedException();
        }

        public FixedPages GetById(int Id)
        {
          return  con.Query<FixedPages>("sp_GetFixedPageById", new { Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IQueryable<FixedPages> GetMany(Expression<Func<FixedPages, bool>> expression)
        {
            throw new NotImplementedException();
        }
        public void AddFixedPage(string Title, string Description,string ImagePath)
        {
            con.Query("sp_insertFixedPage", new { Title, Description, ImagePath }, commandType: CommandType.StoredProcedure);
        }

        public void Insert(FixedPages obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(FixedPages obj)
        {
            con.Execute("sp_updateFixedPage", obj, commandType: CommandType.StoredProcedure);
        }

        public List<FixedPages> GetAllFixedPages()
        { 
           return con.Query<FixedPages>("sp_getAllFixedPages",  commandType: CommandType.StoredProcedure).ToList();
        }
    }
}