namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());



            int[,] matrix = new int[rows, rows];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int cow = 0; cow < rows; cow++)
                {
                    matrix[row, cow] = numbers[cow];
                }
            }

            int primery = 0;
            int secendary = 0;

            for (int i = 0; i < rows; i++) //  заедно се ппоменят 
            {
                primery += matrix[i, i];
                secendary += matrix[rows - i - 1, i];
            }

            Console.WriteLine(Math.Abs(primery - secendary));



        }
    }
}