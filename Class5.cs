using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LogicalPrograms
{
    public class Class5
    {
        public static void main(String[] args)
        {
            int first = 0, Second = 1, next, Elements;
            Console.Write("Enter the number of elements to Print : ");
            Elements = int.Parse(Console.ReadLine());
            if (Elements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(first + " " + Second + " ");
                for (int i = 2; i < Elements; i++)
                {
                    next = first + Second;
                    Console.Write(next + " ");
                    first = Second;
                    Second = next;
                }
            }

            Console.ReadKey();
        }
    }
}