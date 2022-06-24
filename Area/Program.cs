using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area, circum;
            const double PI = 3.14;

            Console.Write("\nEnter the radius of circle ");
            r = Convert.ToDouble(Console.ReadLine());
            area = PI * r * r;
            circum = 2 * PI * r;
            Console.WriteLine("\nThe area of circle is {0}", area);
            //Console.WriteLine("\nThe circumference of circle is {0}", 2 * PI * r);
            Console.WriteLine("\nThe circumference of circle is {0}", circum);

        }
    }
}