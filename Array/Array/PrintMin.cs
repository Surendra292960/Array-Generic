using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class PrintMin
    {
        static void printMin(int[] x)
        {
            int min = x[0];
            int max = x[0];
            for (int i = 0; i < x.Length; i++)
            {
                if (min > x[i])
                {
                    min = x[i];
                }
            }
            Console.WriteLine("Minimum element is: " + min);
        }
            public static void Main(string[] args)
            {
                int[] a1 = { 1, 2, 3, 4, 5, 6 };
                int[] a2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                printMin(a1);
                printMin(a2);
                Console.Read();
            }
        }
}
