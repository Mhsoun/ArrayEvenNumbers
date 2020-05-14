using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 intergers and press enter after each");

            for (int i = 0; i < 10; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out a[i]);
            }

            Console.WriteLine("the even numbers in the arry");
            for (int i = 0; i < 10; i++)
            {
                if (a[i]%2 ==0)
                {
                    Console.WriteLine("[" + a[i] + "]");
                }
            }

        }
    }
}
