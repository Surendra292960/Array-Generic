using System;
namespace Array.Array
{
    class MultipleusesArray
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           
           Console.WriteLine("initial Array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }

            Console.WriteLine("\nOddIndex Array");
            for (int i = 1; i < x.Length - 1; i += 2)
            {
                Console.Write(x[i] + ",");
            }

            Console.WriteLine("\nEvenIndex Array");
            for (int i = 0; i < x.Length - 1; i += 2)
            {
                Console.Write(x[i] + ",");
            }


            Console.WriteLine("\n Reverse Firsthaf Array");
            for (int i = x.Length / 2; i >0; i--) 
            {
                Console.Write(x[i] + ",");
            }

            Console.WriteLine("\n Reverse secondhalf Array");
            for (int i = x.Length-1; i>x.Length / 2; i--)
            {
                Console.Write(x[i] + ",");
            }

            ////////////////////////////////////
            for(int i =4; i<x.Length-1; i++)
            {
                x[i] = x[i + 1];
            }

            int[] y = new int[x.Length - 1];
            for(int i =0; i<y.Length; i++)
            {
                y[i] = x[i];
            }
            Console.WriteLine("\n Remove 4rth index");
            for (int i = 0; i< x.Length-1 ; i++)
            {
                Console.Write(y[i] + ",");
            }

             x[4] = 10;
            Console.WriteLine("\n Add 10 at 4rth index");
            for (int i = 0; i< x.Length-1 ; i++)
            {
                Console.Write(x[i] + ",");
            }

            Console.WriteLine("\n2nd min number");
            int min1 = x[0], min2 = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min1)  // always 1
                {
                    min2 = min1;
                    min1 = x[i];
                }
                else if (x[i] < min2) // 1, 4 when last 3 enter then its true 
                {
                    min2 = x[i];
                }
                else if (min1 == min2 && x[i] > min2)
                {
                    min2 = x[i];
                }
            }
            Console.WriteLine("min2:" + min2);

            Console.WriteLine("\n sum of even indexs");
            for (int i = 0; i < x.Length - 1; i += 2)
            {
                Console.Write(x[i] + ",");
            }



            Console.Read();
        }
    }
}
