using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter a radius r(real number) 
            //and print the area of the circle with exactly 12 digits after the decimal point. 

            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine("{0:f12}",area);
        }
    }
}
