using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "1", "2", "3", "4" };
            Console.WriteLine(String.Join(", ", arr));

            TransformOperations.TransForm(arr, p => p+p);

            Console.WriteLine(String.Join(", ", arr));
            Console.Read();

        }
    }
    

    class TransformOperations
    {
       public static void TransForm<T>(T[] arr, Func<T,T> t)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = t.Invoke(arr[i]);
            }
        }
    }

}
