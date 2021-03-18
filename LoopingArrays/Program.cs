using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[] {"John","James","Peter","Mary","Rose"};
            foreach (var name in names)
            {
                Console.WriteLine("Names of Students are : "+name);
            }
            
           Console.ReadLine();
        }
    }
}
