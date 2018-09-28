using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class ArrayPassAsArgs
    {
        static void printArray(int[] x)
        {
            Console.WriteLine("\nPrinting array elements");
            for(int i=0; i<x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
        }
        static void Main(string[] args)
        {
           
           int[] a1 = { 10, 20, 30, 40, 50 };
           int[] a2 = { 12, 23, 44, 11, 54 };
            printArray(a1);
            printArray(a2);
            Console.Read();

        }

    }
}
