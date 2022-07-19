using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinecomparsionUC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of X1 and Y1 coordinates");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of X2 and Y2 coordinates");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Please enter the value of X3 and Y3 coordinates");
            var x3 = Convert.ToDouble(Console.ReadLine());
            var y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of X4 and Y4 coordinates");
            var x4 = Convert.ToDouble(Console.ReadLine());
            var y4 = Convert.ToDouble(Console.ReadLine());

            var distance1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            var distance2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
    
            var formula = distance1 + distance2;
            Console.WriteLine(formula);

            if (distance1 == distance2)
            {
                Console.WriteLine("both the lines are equal");
            }
            else if ( distance2 > distance1)
            {
                Console.WriteLine(" line2 is greater than line 1");
            }
            else
            {
                Console.WriteLine("line 1 is greater than line 2");
            }
        }
    }
}
