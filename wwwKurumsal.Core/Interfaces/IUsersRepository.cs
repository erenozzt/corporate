using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwwKurumsal.Data;

namespace wwwKurumsal.Core.Interfaces
{
    public interface IUsersRepository : IRepository<Users>
    {
        Users GetUser(string email, string password,bool isActive);
    }
}
