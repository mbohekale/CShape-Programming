using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b,z;

            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //additional expression;
                z =x + y;
            //Subtraction expression;
                z = x - y;
            //Multiplication expression;
                z = x * y;
            //Division expression;
                z = x / y;

            x = (x+y) * (x-a);


            //Equality operator
                if (x==y) { }
            //Greater than operation
                if (x>y) { }
            //Less than operator
                if (x<y) { }
            //Greater than or equals to
                if (x>=y) { }
            //Less or equals to operator
                if (x < y) { }

            //Conditional operators
            // Greater than AND operator
            if ((x > y) && (a < b)) { }
            //Conditional OR operator
            if ((x > y) || (a < b)) { }








        }
    }
}
