using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Core.Interfaces
{
    public interface IFixedPagesRepository : IRepository<FixedPages>
    {
        void AddFixedPage(string Title, string Description,string ImagePath);
        List<FixedPages> GetAllFixedPages();
    }
}
