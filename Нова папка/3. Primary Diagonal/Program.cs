﻿namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = ints[col];
                }
            }

            int sum = 0;
            for (int row = 0; row < size; row++)
            {



                sum += matrix[row, row];

            }

            Console.WriteLine(sum);
        }
    }
}