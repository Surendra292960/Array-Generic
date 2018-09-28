using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Elements of Array");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
