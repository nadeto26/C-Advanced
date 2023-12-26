namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[rows[0], rows[1]];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] cows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = cows[cow];
                }
            }

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    sum += matrix[row, cow];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);



        }
    }
}