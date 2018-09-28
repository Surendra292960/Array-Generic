using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class ClsGeneric1<G1,G2>
    {
        public void Display(G1 s1, G2 s2)
        {
            //Console.WriteLine("Value of s is:" + s1);
            Console.WriteLine("value of s1 and s2 are:{0}:{1}", s1, s2);
        }

    }
    class ClsGeneric2
    {
        static void Main(string[] args)
        {
            ClsGeneric1<string,int> obj1 = new ClsGeneric1<string,int>();
            ClsGeneric1<int,double> obj2 = new ClsGeneric1<int,double>();
            ClsGeneric1<int, string> obj4 = new ClsGeneric1<int, string>();
            ClsGeneric1<double,string> obj3 = new ClsGeneric1<double,string>();
            obj1.Display("Hello",10);
            obj2.Display(10,20.5);
            obj3.Display(10.5,"surendra");
            Console.Read();
        }
    }
}
