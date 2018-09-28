using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Params
    {
        public void Show(params int[] val)
        {
            for(int i=0; i<val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Params p = new Params();
            p.Show(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.Read();

        }
    }
}
