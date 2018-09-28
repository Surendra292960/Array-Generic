using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Single_Array
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];

            x[0] = 10;
            x[1] = 20;
            x[2] = 30;
            x[3] = 40;
            x[4] = 50;
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
            Console.Read();
        }
    }
}
