using Microsoft.EntityFrameworkCore;
using ShopApplication.Data.interfaces;
using ShopApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.Repository
{
    public class BookRepository : IAllBooks
    {
        private readonly AppDBContent appDBContent;
        public BookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Book> Books => appDBContent.Book.Include(c => c.Category);

        public Book getObjectBook(int bookId) => appDBContent.Book.FirstOrDefault(p => p.id == bookId);
    }
}
