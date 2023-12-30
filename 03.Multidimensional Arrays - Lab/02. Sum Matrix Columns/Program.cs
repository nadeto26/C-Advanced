namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split(", ");

            int rols = int.Parse(arrays[0]);
            int cols = int.Parse(arrays[1]);

            int[,] matrix = new int[rols, cols];

            for (int rol = 0; rol < rols; rol++)
            {
                int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {

                    matrix[rol, col] = array[col];
                }

            }


            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int rol = 0; rol < rols; rol++)
                {
                    sum += matrix[rol, col];

                }
                Console.WriteLine(sum);
            }

        }
    }
}