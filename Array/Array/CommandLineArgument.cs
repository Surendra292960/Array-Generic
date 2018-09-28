using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class CommandLineArgument
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argument length:" + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            Console.Read();

            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
            Console.Read();
        }

    }
}
