using ShopApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.interfaces
{
    interface IAllBooks
    {
        IEnumerable<Book> Books { get;}
        Book getObjectBook(int bookId);
    }
}
