using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Jaged3
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 11, 21, 33, 23 };
            A[1] = new int[] { 11, 21, 33 };
            A[2] = new int[] { 2, 5 };

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.Write(A[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

