using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class8
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int small = Math.Min(a, Math.Min(b, c));
            int large=Math.Max(a,Math.Max(b,c));
            int sum = a + b + c;
            Console.WriteLine(sum - large - small);
            Console.WriteLine(a ^ b ^ c ^ small ^ large);
            Console.ReadKey();
        }
    }
}
