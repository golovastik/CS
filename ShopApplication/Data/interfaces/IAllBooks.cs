using ShopApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Books { get;}
        Book getObjectBook(int bookId);
    }
}
