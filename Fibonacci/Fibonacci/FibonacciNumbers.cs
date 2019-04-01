using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciNumbers
    {
        private int number;
        public void ShowFibonacciNumbers()
        {
            FibonacciInfo();
            for (int i = 1; i <= number; ++i)
            {
                Console.WriteLine("Fibonacci number [{0}] = {1}", i, FibonacciStart(i));
            }
            Console.ReadKey();
        }

        private void FibonacciInfo()
        {
            string s;
            Console.WriteLine("Enter your numeric:");
            s = Console.ReadLine();
            if (Int32.TryParse(s, out number))
            {
                number = Convert.ToInt32(s);
            }
            else
            {
                Console.WriteLine("Input only numeric! Please repeat!");
                FibonacciInfo();
            }
        }

        private static int FibonacciStart(int n)
        {
            if (n == 1 || n ==2 )
            {
                return 1;
            }
            else
            {
                return FibonacciStart(n - 1) + FibonacciStart(n - 2);
            }
        }
    }
}
