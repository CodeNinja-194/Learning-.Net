using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
namespace LogicalPrograms
{
    public class Class4
    {
        static void main(string[] args)
        {
            Console.Write("Enter the Nth number of the Fibonacci Series : ");
            int N = int.Parse(Console.ReadLine());
            N = N - 1;
            Console.Write(NthFibonacci(N));
            Console.ReadKey();
        }
        private static int NthFibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (NthFibonacci(n - 1) + NthFibonacci(n - 2));
            }
        }
    }
}