using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class SwapiingArray
    {
        static void Main(string[] args)
        {
            int[] x = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("initial Array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
            int temp = x[3];
            x[3] = x[5];
            x[5] = temp;

            Console.WriteLine("initial Array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
            Console.Read();
        }
    }
}
