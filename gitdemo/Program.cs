using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            int add = num1 + num2;
            Console.WriteLine("Addition:",add);
        }
    }
}
