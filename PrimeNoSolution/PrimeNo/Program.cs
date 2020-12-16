using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower, upper, i, j, flag;
            Console.WriteLine("Enter lower bound of " +
                      "the interval: ");
            lower = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter upper bound of " +
                     "the interval: ");
            upper = int.Parse(Console.ReadLine());

            for (i = lower; i <= upper; i++)
            {
                if (i == 1 || i == 0)
                    continue;

                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
            }



        }
    }
}
