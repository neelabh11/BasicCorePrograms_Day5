using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public static class EvenOdd
    {
        public static void CheckEvenOrOdd()
        {
            int i;
            Console.WriteLine("Enter a number: ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is even");
            }
            else
            {
                Console.WriteLine(i + " is odd");
            }
        }
    }
}
