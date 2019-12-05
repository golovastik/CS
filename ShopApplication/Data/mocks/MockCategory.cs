using ShopApplication.Data.interfaces;
using ShopApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                //указываем какие у нас есть категории
                return new List<Category>
                {
                    new Category{ categoryName = "Научная литература", desc = "программирование, интернет"},
                    new Category{ categoryName = "Фантастика", desc = "комиксы, манга"}
                };
            }
        }
    }
}
