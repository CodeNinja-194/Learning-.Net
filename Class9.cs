using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class9
    {
        static void main(string[] args)
        {
            int[] arr = new int[3];
            Console.WriteLine("Enter  array Elements ");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Array.Sort(arr);
            if (arr[0] > arr[1])
            {
                int temp = arr[0];
                arr[0] = arr[1];
                arr[1] = temp;
            }
            if (arr[1] > arr[2])
            {
                int temp = arr[1];
                arr[1] = arr[2];
                arr[2] = temp;
            }
            if (arr[0] > arr[1])
            {
                int temp = arr[0];
                arr[0] = arr[1];
                arr[1] = temp;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
