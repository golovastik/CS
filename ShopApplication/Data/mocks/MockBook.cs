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
                    new Book{name = "C# CRL", shortDesc = "прог", longDesc = "много читать", img = "https://cloud.mail.ru/public/Hdia/2Br38EPqg/CRL_CS.jpg", price = 32, availabel = true, Category = _categoryBooks.AllCategories.First()},
                    new Book{name = "C# 7.0", shortDesc = "прог", longDesc = "тут ты узнаешь что то новое", img = "https://cloud.mail.ru/public/Hdia/2Br38EPqg/CS7.0.jpg", price = 41, availabel = true, Category = _categoryBooks.AllCategories.First()},
                    new Book{name = "C# .NET Core", shortDesc = "", longDesc = "для супер пупер прогГеров", img = "https://cloud.mail.ru/public/Hdia/2Br38EPqg/NETCore.jpg", price = 110, availabel = true, Category = _categoryBooks.AllCategories.First()},
                    new Book{name = "Reack and Morty", shortDesc = "фан", longDesc = "про двух чудаков", img = "https://cloud.mail.ru/public/Hdia/2Br38EPqg/randm.jpg", price = 110, availabel = true, Category = _categoryBooks.AllCategories.Last()},
                    new Book{name = "WarCraft", shortDesc = "фан", longDesc = "интересная книга", img = "https://cloud.mail.ru/public/Hdia/2Br38EPqg/warcraft.jpg", price = 23, availabel = true, Category = _categoryBooks.AllCategories.Last()}
                };
            }
        }
        ////////////////////////////////////////////////////////
        public string(string first, int key){
            string[] array_letter = {A, B, C, D, F, G, H};
            string change_string;
            for(int i = 0, i < first.Length(), i++){
                for(int k = 0, k < array_letter.Length(), k++){
                    if(first[i] == " "){
                        chahge_string.Add(" ");
                        break;
                    }
                    if(first[i] == "," || first[i] == "." || first[i] == "!"){
                        chahge_string.Add(first[i]);
                        break;
                    }
                    if(array_letter[k] == first[i]){
                        string letter_change = array_letter[k + key]
                        chahge_string.Add(letter_change);
                        break;
                    }
                }
                
            }
            retuent change_string;
        }
        //////////////////////////////////////////////////////////

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
