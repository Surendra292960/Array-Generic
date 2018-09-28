using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] A = new int[6] { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Elements of Array");
            foreach(int i in A)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nEnter the size of Array ");
            int N = Convert.ToInt32(Console.ReadLine());
            //Array.Resize(ref A, N);           
            Console.WriteLine("Elements of Array After Resize");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
