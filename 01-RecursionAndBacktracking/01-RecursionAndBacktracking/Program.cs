using System;
using System.Linq;

namespace _01_RecursionAndBacktracking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

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
