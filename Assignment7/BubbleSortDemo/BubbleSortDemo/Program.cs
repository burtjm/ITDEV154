using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());  //Read array size.
            Console.WriteLine("Enter elements");


            string[] usrInput = Console.ReadLine().Split(' '); 

            int[] inputArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                inputArray[i] = int.Parse(usrInput[i]); //Assign user input to array.
            }

            BubbleSort(inputArray);

            Console.WriteLine("The sorted array is ");

            for (int k = 0; k < inputArray.Length; k++)
            {
                Console.Write(inputArray[k] + " "); //Print the sorted array to console.
            }
            Console.ReadLine();
        }

        public static void BubbleSort(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //Swap the elements
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }

}