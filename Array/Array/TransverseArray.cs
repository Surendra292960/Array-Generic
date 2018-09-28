using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class TransverseArray
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50 };
            foreach(int i in x)
            {
                Console.Write(i + ",");
            }
            Console.Read();
        }
    }
}
