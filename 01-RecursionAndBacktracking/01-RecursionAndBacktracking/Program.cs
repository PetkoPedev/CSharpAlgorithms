using System;

namespace _01_RecursionAndBacktracking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(CalcSum(array, 0));
        }

        private static int CalcSum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + CalcSum(array, index + 1);
        }
    }
}
