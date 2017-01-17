using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter n numbers and calculate and print their exact sum (without rounding).

            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for(int i=0; i<n; i++)
            {
                sum+= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
