using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayChecker arrayChecker = new ArrayChecker();
            int[] array = { 1, 2, 3 }; // Initialize the array

            // Check if the array contains the value 4
            bool containsValue = arrayChecker.Contains(array, 4);

            // Output the result
            Console.WriteLine(containsValue); // Should print: False
        }
    }

    class ArrayChecker
    {
        public bool Contains(int[] arr, int value)
        {
            foreach (int i in arr)
            {
                if (i == value)
                {
                    return true;
                }
            }
            return false; // Return false if the value is not found
        }
    }
}
