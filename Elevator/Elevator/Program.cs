using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. 

            int n = int.Parse(Console.ReadLine());

            int p = int.Parse(Console.ReadLine());

            int courses=0;

            if(n%p==0)
            {
                courses = n / p;
            }
            else
            {
                courses = n / p+1;
            }

            Console.WriteLine(courses);

        }
    }
}
