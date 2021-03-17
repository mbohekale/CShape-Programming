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
            if (userValue == "1")
            {
                String message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                String message = "You won a new house!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                String message = "You won a new wife!";
                Console.WriteLine(message);
            }
            else {
                String message = "NULL!";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
