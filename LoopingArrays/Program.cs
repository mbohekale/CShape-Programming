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
            for (int i=0; i<10; i++)
            {
                if (i==7)
                {
                    Console.WriteLine("Not Found! ");
                    break;
                }
               
            }

            for (int y = 0; y < 12; y++)
            {
                Console.WriteLine(y);

            }

            Console.ReadLine();
        }
    }
}
