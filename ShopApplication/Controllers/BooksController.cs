using Microsoft.AspNetCore.Mvc;
using ShopApplication.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Controllers
{
    public class BooksController : Controller
    {
        // класс показывает чтото вроде HTML страницы 
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }

        //пепредача в HTML страницу
        public ViewResult List()
        {
            var buks = _allBooks.Books;
            return View();
        }

    }
}
