using System;

namespace P04_RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcFact(n));
        }

        private static int CalcFact(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalcFact(n - 1);
        }
    }
}
