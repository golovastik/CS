using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        //у товара может быть только одна категория но у одной категории много товаров
        public List<Book> books { get; set; }

    }
}
