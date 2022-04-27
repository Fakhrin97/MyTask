using System;

namespace BookShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set a Limit:");
            var booksCount = Convert.ToInt32(Console.ReadLine());

            Book [] Books = new Book[booksCount];

            for (int i = 0; i < booksCount; i++)
            {
                Console.Write("Enter Id:");
                byte no = Convert.ToByte(Console.ReadLine());
                Console.Write("Enter name:");
                string name = Console.ReadLine();
                Console.Write("Enter Price:");
                byte price = Convert.ToByte(Console.ReadLine());
                Console.Write("Enter Count:");
                byte count = Convert.ToByte(Console.ReadLine());
                Console.Write("Enter Gender:");
                string genre = Console.ReadLine();

                var book = new Book(no, name, price, count, genre);
                Books[i] = book;
            }
            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine();

            bool resualt = false;
            char SelectNumber;
            while (!resualt)
            {
                Console.WriteLine("1.Kiyablari Qiymetlerine Gore Filterle.");
                Console.WriteLine("2.Butun Kitablari Goster.");
                Console.WriteLine("0.Proqrami Bagla.");
                Console.WriteLine();
                Console.WriteLine("*************************************************************************************");
                Console.WriteLine();
                SelectNumber = Convert.ToChar(Console.ReadLine());
                if (SelectNumber == '1')
                {
                    Console.Write("Set Min Prace:");
                    byte minPrace = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Set Max Prace:");
                    byte maxPrace = Convert.ToByte(Console.ReadLine());

                    GetPraces(Books, minPrace, maxPrace);

                }
                else if (SelectNumber == '2') GetBook(Books);
                else if (SelectNumber == '0') resualt = true;

            }
        }
        public static void GetPraces(Book[] Books, byte minPrace, byte maxPrace)
        {
            foreach (var item in Books)
            {
                if (item.Price > minPrace && item.Price < maxPrace)
                {
                    Console.WriteLine($"No:{item.No} Name:{item.Name} Price:{item.Price} Azn Count:{item.Count} Genre:{item.Genre} ");

                }
                Console.WriteLine();
                Console.WriteLine("*************************************************************************************");
                Console.WriteLine();
            }
        }
        public static void GetBook(Book[] Books)
        {
            foreach (var item in Books)
            {
                Console.WriteLine($"No:{item.No} Name:{item.Name} Price:{item.Price} Azn Count:{item.Count} Genre:{item.Genre} ");

            }
            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine();
        }
    }
}
