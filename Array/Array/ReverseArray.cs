using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("\nInitial Array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
            Console.WriteLine("\n Final Array");
            for (int i=x.Length-1; i>0; i--)
            {
                Console.Write(x[i] + ",");
            }
            Console.Read();
        }
    }
}
