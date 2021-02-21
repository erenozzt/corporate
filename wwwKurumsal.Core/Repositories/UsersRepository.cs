using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Dapper;
using Microsoft.Extensions.Configuration;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Data;

namespace wwwKurumsal.Core.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private SqlConnection con;
        public UsersRepository()
        {
            con  = new SqlConnection(ConfigurationManager.ConnectionStrings["Kurumsal"].ConnectionString);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
           return con.Query<Users>("sp_getAllUsers", commandType: CommandType.StoredProcedure);
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Users> GetMany(Expression<Func<Users, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Users GetUser(string email,string password, bool isActive)
        {
            return con.Query<Users>("sp_GetLoginUser", new { email,password, isActive }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public void Insert(Users obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Users obj)
        {
            throw new NotImplementedException();
        }
    }
}