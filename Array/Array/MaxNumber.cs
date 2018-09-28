using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class MaxNumber
    {
        static void printMax(int[] x)
        {
            int max = x[0];
            for (int i = 0; i < x.Length; i++)
            {
               if(max<x[i])
                {
                    max = x[i];
                }
            }
        Console.WriteLine("Maximum number elements is:"+max);
    }
    public static void Main(string[] args)
    {
        int[] a1 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] a2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        printMax(a1);
        printMax(a2);
        Console.Read();
    }
  }
}
