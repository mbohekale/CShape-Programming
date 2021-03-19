sing System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application();
        }
        private static void Application()
        {
            Console.WriteLine("Name Game");
            Console.Write("What is your fname:? ");
            string fname = Console.ReadLine();

            Console.Write("What is your lname:? ");
            string lname = Console.ReadLine();

            Console.Write("Where were you born:? ");
            string cityname = Console.ReadLine();

            
            string result = "";

            foreach (var item in fname)
            {
                result += item;
            }

            Console.WriteLine("My Names are :" + fname +" " + lname + " from " + cityname);
            Console.ReadLine();

        }
    }
   
}