using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose sub-program to run\n");
            Console.WriteLine("(1) Factorial");
            Console.WriteLine("(2) Decimal Number Conversions");
            Console.WriteLine("(3) Greatest Common Disvisor");
            Console.WriteLine("(4) Fibonacci Sequence to n places");
            Console.WriteLine("(5) Tower of Hanoi solutions");
            Console.WriteLine("(6) Quit");

            int s = Convert.ToInt32(Console.ReadLine());

            switch (s)
            {
                case 1:
                    Factorial f = new Factorial();
                    f.FactorialCalc();
                    break;
                case 2:
                    Conversion c = new Conversion();
                    break;
                case 3:
                    GCD g = new GCD();
                
                    break;
                case 4:
                    int p;
                    Fibonacci fi = new Fibonacci();
                  
                    break;
                case 5:

                    TowerofHanoi t = new TowerofHanoi();
                   
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
        }
    }
}
