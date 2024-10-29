using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("side1=");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("side2=");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"S={side1}*{side2}={side1 * side2}");
            Console.WriteLine($"P=({side1}+{side2})*2={(side1 + side2) * 2}");
            Console.ReadKey();
        }
    }
}
