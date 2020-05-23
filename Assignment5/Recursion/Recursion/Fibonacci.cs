using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Fibonacci
    {
        public void Fibonacci_Iterative(int len)
        {


            int num = 0;

            fibonacci(num);
        }

        public static int fibonacci(int num)
        {
            Console.Write("Enter number of terms for the Fibonacci series:");
            num = int.Parse(Console.ReadLine());

            Console.Write("The Fibonacci series of {0} is :", num);

            if (num == 0 || num == 1)
            {
                return 0;
            }
            else
            {

                int first = 0;
                int second = 1;
                int sum = 0;


                Console.Write(" " + first);
                Console.Write(" " + second);

                for (int i = 0; i < num - 2; i++)
                {
                    sum = first + second;
                    Console.Write(" " + sum + " ");
                    first = second;
                    second = sum;
                }
                return sum;
            }
        }
    }
    }
