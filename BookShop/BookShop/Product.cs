using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    internal class Product
    {
        public byte No { get; set; }    
        public string Name { get; set; }    
        public byte Price { get; set; } 
        public byte Count { get; set; }

        public Product(byte no, string name, byte price, byte count)
        {
            No = no;
            Name = name; 
            Price = price;
            Count = count;  
        }
    }
}
