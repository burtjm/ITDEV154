using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class GCD
    {

        public static int GCDCALC(int n1, int n2)
        {
            if (n2 != 0)
                return GCDCALC(n2, n1 % n2);
            else
                return n1;
        }
        static void Main(string[] args)
        {
            int n1 = 3, n2 = 47;
            int hcf = GCDCALC(n1, n2);
            Console.Write("GCD) of {0} and {1} is {2}.", n1, n2, hcf);
            Console.ReadKey();
        }
    }
}
