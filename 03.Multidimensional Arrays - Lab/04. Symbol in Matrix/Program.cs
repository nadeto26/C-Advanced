namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string sumbols = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = sumbols[col];
                }
            }

            char countainSumbol = char.Parse(Console.ReadLine());

            bool isFound = false;

            for (int row = 0; row < size; row++)
            {


                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == countainSumbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }

                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{countainSumbol} does not occur in the matrix ");

            }









        }
    }
}