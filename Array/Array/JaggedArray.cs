using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 10, 20, 30, 40 };
            A[1] = new int[] { 10, 20, 30 };
            A[2] = new int[] { 10, 20 };
            Console.WriteLine("Elements Jagged Array:");
            //for(int r=0; r<A.Length; r++)
            //{
            //    for(int c=0; c<A[r].Length; c++)
            //    {
            //        Console.Write(A[r][c]+" ");
            //    }
            //    Console.WriteLine();

            foreach(int[] r in A)
            {
                foreach(int c in r)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
