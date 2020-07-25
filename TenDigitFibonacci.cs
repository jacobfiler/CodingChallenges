using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            //The Fibonacci sequence is defined by the recurrence relation:

            //Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.

            //What is the index of the first term in the Fibonacci sequence to contain 10 
            //digits ?

            int a = 0;
            int b = 1;
            int c = 0;
            int index = 0;
            List<int> fibonacci = new List<int>();

            #region not a list
            //while (c <= 1000000000)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;
            //    index++
            //    //Console.WriteLine($"{c:n0} Index of {index}");

            //}
            //Console.WriteLine($"\nThe first term in the fibonacci sequence that has a value of 10 digits is {c:n0} with an index of {index");

            #endregion

            while (c <= 1000000000)
            {
                c = a + b;
                a = b;
                b = c;
                fibonacci.Add(c);
                //Console.WriteLine($"{c:n0} Index of {fibonacci.Count() - 1 }");

            }
            Console.WriteLine($"\nThe first term in the fibonacci sequence that has a value of 10 digits is {c:n0} with an index of {fibonacci.Count() - 1 }");
        }
    }
}
