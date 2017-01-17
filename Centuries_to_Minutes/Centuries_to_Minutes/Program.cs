using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.

           int centuries = int.Parse(Console.ReadLine());

            double years = centuries * 100;

            double days = Math.Round(years * 365.2422);

            double hours =Math.Round( days * 24);

            double minutes = Math.Round(hours * 60);

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                                                        centuries, years, (int)days, (int)hours, (int)minutes);

        }
    }
}
