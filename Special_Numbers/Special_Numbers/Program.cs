using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A number is special when its sum of digits is 5, 7 or 11.
            //Write a program to read an integer n and for all numbers in the range 1…n 
            //to print the number and if it is special or not (True / False).

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num;

            for (int i = 1; i<=n; i++)
            {
                num = i;
                while(num>0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine(i+" -> True");
                }
                else
                {
                    Console.WriteLine(i + " -> False");
                }
                sum = 0;
            }
        }
    }
}
