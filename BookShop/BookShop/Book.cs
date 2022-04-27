using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    internal class Book: Product
    {
        public string Genre { get; set; }
      
        public Book(byte no, string name , byte price, byte count,string genre): base(no,name,price,count)
        {
            Genre = genre;
        }
    }
}
