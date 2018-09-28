using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class ArrayClass1
    {
        static void Main(string[] args)
        {
            string[] A = new string[5] { "a", "b", "c", "d", "e" };
            Console.WriteLine("Elements of Array");

            foreach(string i in A)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
