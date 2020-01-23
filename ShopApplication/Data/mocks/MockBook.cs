using ShopApplication.Data.interfaces;
using ShopApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.mocks
{
    public class MockBook : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book{name = "C# CRL", shortDesc = "прог", longDesc = "много читать", img = "/img/CRL_CS.jpg", price = 32, availabel = true, Category = _categoryBooks.AllCategories.First()},
                    new Book{name = "C# 7.0", shortDesc = "прог", longDesc = "тут ты узнаешь что то новое", img = "/img/CS7.0.jpg", price = 41, availabel = true, Category = _categoryBooks.AllCategories.First()},
                    new Book{name = "C# .NET Core", shortDesc = "прог", longDesc = "для супер пупер прогГеров", img = "/img/NETCore.jpg", price = 110, availabel = true, Category = _categoryBooks.AllCategories.First()},
                    new Book{name = "Reack and Morty", shortDesc = "фан", longDesc = "про двух чудаков", img = "/img/randm.jpg", price = 110, availabel = true, Category = _categoryBooks.AllCategories.Last()},
                    new Book{name = "WarCraft", shortDesc = "фан", longDesc = "интересная книга", img = "/img/warcraft.jpg", price = 23, availabel = true, Category = _categoryBooks.AllCategories.Last()}
                };
            }
        }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
