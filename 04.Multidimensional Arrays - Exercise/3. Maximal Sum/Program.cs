namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[,] matrix = new int[numbers[0], numbers[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = array[cow];
                }
            }

            int maxSum = int.MinValue;
            int maxRol = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int cow = 0; cow < matrix.GetLength(1) - 2; cow++)
                {
                    int currentSum = +matrix[row, cow] + matrix[row, cow + 1] + matrix[row, cow + 2] +
                    matrix[row + 1, cow] + matrix[row + 1, cow + 1] + matrix[row + 1, cow + 2] +
                    matrix[row + 2, cow] + matrix[row + 2, cow + 1] + matrix[row + 2, cow + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRol = row;
                        maxCol = cow;
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRol; row < maxRol + 3; row++)
            {

                for (int cow = maxRol; cow < maxCol + 3; cow++)
                {
                    Console.Write(matrix[row, cow] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}