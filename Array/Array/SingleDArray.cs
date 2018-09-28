using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class SingleDArray
    {
        static void Main(string[] args)
        {
            int[] x = new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Elements Of The Array");

            for(int i=0; i<6; i++)
            {
                Console.Write(x[i] + " ,");
            }
            Console.Read();
        }

    }
}
