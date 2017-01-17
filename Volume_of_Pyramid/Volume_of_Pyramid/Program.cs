using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");

            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            double wight = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            double  height = double.Parse(Console.ReadLine());
            double V = (lenght * wight * height) /3;

            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}
