using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[] arr = { 20, 30, 10, 50, 40 };
            Console.WriteLine("Unsorted Array");
            display(arr);
            Console.WriteLine("Sorted Array");
            display(selectionsort(arr));
            Console.ReadKey();


        }

        public static int[] selectionsort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int begin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[begin])
                    {
                        begin = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[begin];
                arr[begin] = temp;
            }
            return arr;
        }

        public static void display(int[] arr)
        {
            for (int lcv = 0; lcv < arr.Length; lcv++)
            {
                Console.WriteLine(arr[lcv]);
            }


        }


    }
}