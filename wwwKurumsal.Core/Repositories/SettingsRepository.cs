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
    public class SettingsRepository : ISettingsRepository
    {
        private readonly SqlConnection con;
        public SettingsRepository()
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

        public IEnumerable<Settings> GetAll()
        {
            throw new NotImplementedException();
        }

        public Settings GetById(int id)
        {
            return con.Query<Settings>("sp_GetSettingById", new { id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IQueryable<Settings> GetMany(Expression<Func<Settings, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Settings obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Settings obj)
        {
            con.Execute("sp_updateSettings", obj, commandType: CommandType.StoredProcedure);
        }
    }
}