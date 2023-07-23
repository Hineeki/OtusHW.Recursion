using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OtusHW.Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
            Console.WriteLine(Fibonacci(10));
            Console.WriteLine(Fibonacci(20));

            FibonacciCycle(5);
            FibonacciCycle(10);
            FibonacciCycle(20);
        }
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void FibonacciCycle(int value)
        {
            List<int> list = new List<int>(20) { 0, 1 };
            if (value < 0)
            {
                while (list.Count <= value * -1)
                {
                    list.Add(list[list.Count - 1] + list[list.Count - 2]);
                }
                Console.WriteLine(list[list.Count - 1] * -1);
            }
            else
            {
                while (list.Count <= value)
                {
                    list.Add(list[list.Count - 1] + list[list.Count - 2]);
                }
                Console.WriteLine(list[list.Count - 1]);
            }
        }
    }
}
