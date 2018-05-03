using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Console.WriteLine("COUNT:" + books.Count);
            books.Add(new Book() { Title="C#", Price=250});
            books.Add(new Book() { Title = "WPF", Price = 500 });
            books.Add(new Book() { Title = "C#", Price = 450 });
            books.Add(new Book() { Title = "ASP.NET", Price = 1500 });
            Console.WriteLine("COUNT:" + books.Count);
            

            var newBooks = books.ConvertAll
                (book=> new PriceBook()
                { Price = book.Price, FullPrice = book.Price * 1.20m });

            bool IsBookExist = books.Exists(p => p.Price > 500);
            books.Contains(new Book() { Title = "WPF", Price = 500 });

            var lstBooks = books.FindAll(p => p.Price > 500);
            Book first = books.Find(p => p.Price > 500);
            int iFirst = books.FindIndex(p => p.Price > 500);

            books.ForEach(p => p.Price += 100);

            books.ForEach(p => Console.WriteLine(p.Title));

            books.Sort((b1, b2)=>b1.Price.CompareTo(b2.Price));

            bool d = books.TrueForAll(p => p.Price > 250);

            books.RemoveRange(5, 50);
;
          Console.Read();
        }
    }

    class PriceBook
    {
        public decimal Price { get; set; }
        public decimal FullPrice { get; set; }
    }


}
