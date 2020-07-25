using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class LongestCollatz
    {
        static void Main(string[] args)
        {
            //int test = 13;
            //do
            //{
            //    if (test % 2 == 0)
            //    {
            //        test = test / 2;
            //    }
            //    else
            //    {
            //        test = (test * 3) + 1;
            //    }
            //    Console.WriteLine(test);
            //} while (test != 1);


            Dictionary<int, int> results = new Dictionary<int, int>();

            for (int i = 1; i < 1000; i++)
            {
                int test = i;
                int iterations = 0;
                do
                {
                    if (test % 2 == 0)
                    {
                        test = test / 2;
                    }
                    else
                    {
                        test = (test * 3) + 1;
                    }
                    iterations++;
                    //Console.WriteLine(iterations);
                } while (test != 1);
                results.Add(i, iterations);
            }

            var max = results.FirstOrDefault(x => x.Value == results.Values.Max()).Key;

            Console.WriteLine(max);






        }
    }
}
