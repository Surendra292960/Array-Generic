using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Array2
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 10, 20, 30, 40 };
            Console.WriteLine("Elements of the Array are:");
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nLength is:" + A.Length);
            Console.WriteLine("\nRank is:" + A.Rank);
            Console.Read();
        }

    }
}
