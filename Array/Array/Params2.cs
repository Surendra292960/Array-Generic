using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Params2
    {
        public void  Show(params object[] items)
        {
            for(int i=0; i<items.Length; i++)
            {
                Console.WriteLine(items[i] + ",");
            }
        }
        static void Main(string[] args)
        {
            Params2 p2 = new Params2();
            p2.Show("Surendra", "Ramesh",101,20.50,"Peter", 'A');
            Console.Read();
        }
    }
}
