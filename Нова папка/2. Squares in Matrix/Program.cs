namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            char[,] matrix = new char[numbers[0], numbers[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] array = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = array[cow];
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int cow = 0; cow < matrix.GetLength(1) - 1; cow++)
                {
                    if (matrix[row, cow] == matrix[row, cow + 1]
                        && matrix[row, cow] == matrix[row + 1, cow + 1]
                        && matrix[row, cow] == matrix[row + 1, cow])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
    }
}