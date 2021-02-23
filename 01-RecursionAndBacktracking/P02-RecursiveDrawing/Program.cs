using System;

namespace P02_RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DrawFigure(n);
        }

        private static void DrawFigure(int size)
        {
            if (size == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', size));
            DrawFigure(size - 1);
            Console.WriteLine(new string('#', size));
        }
    }
}
