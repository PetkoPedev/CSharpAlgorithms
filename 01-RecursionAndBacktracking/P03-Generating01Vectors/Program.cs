﻿using System;

namespace P03_Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var vector = new int[n];

            Gen01(vector, 0);
        }

        private static void Gen01(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int number = 0; number <= 1; number++)
            {
                vector[index] = number;
                Gen01(vector, index + 1);
            }
        }
    }
}
