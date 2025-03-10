﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwwKurumsal.Data.DbModel;

namespace wwwKurumsal.Core.Interfaces
{
    public interface ICategoriesRepository :IRepository<Categories>
    {
        List<Categories> GetAllCategories();
    }
}
