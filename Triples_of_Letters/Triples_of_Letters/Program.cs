using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n 
            //and print all triples of the first n small Latin letters, ordered alphabetically

            int n = int.Parse(Console.ReadLine());
            char letter;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    for(int k=0; k<n; k++)
                    {
                        letter = (char)('a' + i);
                        Console.Write(letter);
                        letter = (char)('a' + j);
                        Console.Write(letter);
                        letter = (char)('a' + k);
                        Console.Write(letter);
                        Console.WriteLine();
                    }
                    
                }
            }
        }
    }
}
