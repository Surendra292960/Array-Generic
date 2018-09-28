using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class JaggedArrayRank
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[5] { 1, 2, 3, 4, 5 };
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };
            Console.WriteLine("Elements of the Array");
            foreach (int[] i in A)
            {
                foreach (int c in i)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Length of Array is:" + A.Length);
            Console.WriteLine("Rank of Array is:" + A.Rank);
            Console.Read();

        }
    }
}
