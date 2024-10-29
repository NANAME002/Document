using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("side1=");
            int side1= int.Parse(Console.ReadLine());
            Console.Write("side2=");
            int side2= int.Parse(Console.ReadLine());
            Console.WriteLine($"S={side1}*{side2}={side1 * side2}");
            Console.WriteLine($"P=({side1}+{side2})*2={(side1 + side2) * 2}");
            Console.ReadKey();
        }
    }
}
