using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Multi2
    {
        static void Main(string[] args)
        {
            int[,] A= { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i =0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(A[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
