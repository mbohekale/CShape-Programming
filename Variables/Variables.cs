using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your Firstname?");
            Console.Write("Wirte Your First name: ");
            String Firstname;
            Firstname = Console.ReadLine();

            Console.WriteLine("What is your Lastname?");
            Console.Write("Write Your Last name: ");
            String Lastname;
            Lastname = Console.ReadLine();

            Console.WriteLine("My Firstname is :" + Firstname + "and" + " Lastname is "+ Lastname);
            Console.ReadLine();
        }
    }
}