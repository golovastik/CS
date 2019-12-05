using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }   //описание до нажатия(мало)
        public string longDesc { get; set; }    //описание после(много)
        public string img { get; set; }
        public ushort price { get; set; }   //цены не будет со знаком минус
        public bool availabel { get; set; }  //доступно для продажи
        //связывание товара с категорией
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
