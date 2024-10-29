using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=  ");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"a+b+c={a + b + c}");
            Console.ReadKey();
        }
    }
}
