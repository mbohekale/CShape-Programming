using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob won the Game");
            Console.Write("Choose a door: 1 ,2 or 3: ");
            string userValue = Console.ReadLine();
            String message ="";

            message= (userValue == "1") ? "boat" : "car";

            Console.Write("You won a!");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}