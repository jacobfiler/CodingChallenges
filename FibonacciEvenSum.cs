using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            /*
                Each new term in the Fibonacci sequence is generated
                by adding the previous two terms. By starting with
                1 and 2, the first 10 terms will be:

                1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

                By considering the terms in the Fibonacci sequence
                whose values do not exceed four million, find the
                sum of the even-valued terms.
             */
            int sum = 0;
            int a = 0;
            int b = 1;
            int c;
            //for (int i = 0; i < 89; i++)
            //{
            //    int c = a + b;
            //    a = b;
            //    b = c;
            //    Console.WriteLine(c);
            //    if (c % 2 == 0 && c < 4000000)
            //    {
            //        sum += c;
            //    }
            //}
            //Console.WriteLine($"{sum:n0}");

            do
            {
                c = a + b;
                a = b;
                b = c;
                if (c % 2 == 0 && c < 4000000)
                {
                    sum += c;
                    //Console.WriteLine($"{c:n0}");
                }
            } while (a < 4000000 );
            Console.WriteLine($"\nThe sum is {sum:n0}");
        }
    }
}
