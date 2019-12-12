using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApplication.Data.Models;

namespace ShopApplication.Data.interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
