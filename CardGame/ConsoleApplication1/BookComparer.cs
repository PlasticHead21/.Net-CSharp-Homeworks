using System;
using System.Collections.Generic;
//using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BookComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            return x.Title.Equals(y.Title);
        }

        public int GetHashCode(Book obj)
        {
            return obj.Title.GetHashCode();
        }
    }
}
