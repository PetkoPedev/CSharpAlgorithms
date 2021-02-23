using System;
using System.Collections.Generic;

namespace P06_QueensPuzzle
{
    public class Program
    {
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        private static HashSet<int> attackedRightDigonals = new HashSet<int>();

        static void Main(string[] args)
        {
            var board = new bool[8, 8];

            PutQueens(board, 0);
        }

        private static void PutQueens(bool[,] board, int row)
        {
            if (row == board.GetLength(0))
            {
                PrintBoard(board);
                return;
            }

            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (!IsAttacked(board, row, col))
                {
                    board[row, col] = true;
                    attackedRows.Add(row);
                    attackedCols.Add(col);
                    attackedLeftDiagonals.Add(row - col);
                    attackedRightDigonals.Add(row + col);

                    PutQueens(board, row + 1);

                    board[row, col] = false;
                    attackedRows.Remove(row);
                    attackedCols.Remove(col);
                    attackedLeftDiagonals.Remove(row - col);
                    attackedRightDigonals.Remove(row + col);
                }
            }
        }

        private static bool IsAttacked(bool[,] board, int row, int col)
        {
            return attackedRows.Contains(row) ||
                attackedCols.Contains(col) ||
                attackedLeftDiagonals.Contains(row - col) ||
                attackedRightDigonals.Contains(row + col);
        }

        private static void PrintBoard(bool[,] board)
        {
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if (board[r, c])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
