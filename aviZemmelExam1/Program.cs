using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static int kefel()
        {
            int sum = 0;
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            int num2 = int.Parse(Console.ReadLine());

            while (num1 > 0)
            {
                sum = sum + num2;
                num1--;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(kefel());

        }
    }
}