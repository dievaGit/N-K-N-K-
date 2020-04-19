using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            BigInteger F1 = 1, F2 = 1, result = 0;
            int n = 0, k = 0;


            //Requesting numerator and denominator
            Console.Write(" Enter the numerator: ");
            n = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(" Enter the denominator: ");
                k = Convert.ToInt32(Console.ReadLine());
            }
            while (k > n);

            //calculating the factorials
            for (int i = n; i > 0; i--)
            {
                F1 *= i;
            }

            for (int i = n; i > 0; i--)
            {
                F1 *= i;
            }
            result = F1 * F2;

            Console.Write(" N! * K! = {0}", result);

            Console.ReadKey();

        }
    }
}
