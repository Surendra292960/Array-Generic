using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class CopyTo
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 10, 20, 30, 40, 50 };
            int[] B = new int[9] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Console.WriteLine("Elements of the Array A:");
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n Elements Of the Array B:");
            foreach(int i in B)
            {
                Console.Write(i + " ");
            }
            A.CopyTo(B, 2);
            Console.WriteLine("\n Elements Of the Array After COpy:");
            foreach (int i in B)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
