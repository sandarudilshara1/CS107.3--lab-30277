using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i=0;j<10;i++)
            {
                Console.WriteLine("Enter the number:");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("it's even");
                }
                else
                {
                    Console.WriteLine("it's odd");
                }
                Console.ReadLine();
            }
        }
    }
}
