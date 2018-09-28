using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class ClsGeneric
    {
        static void Display<G>(G s)
        {
            Console.WriteLine("Value of  s is :" + s);
        }
        static void Main(string[] args)
        {
            Display<int>(10);
            Display<string>("hello");
            Display<double>(10.5);
            Console.Read();
        }
    }
}
