using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Person p = new Person();
            //p.Calculation(2,3);
            Console.WriteLine("Solution is  : " + p.Calculation(2,3));
            Console.ReadLine();

        }
    }
}
