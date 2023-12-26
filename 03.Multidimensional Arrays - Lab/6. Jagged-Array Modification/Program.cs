namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nt size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


                matrix[row] = numbers;

            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splittedCommand = command.Split(" ");

                int row = int.Parse(splittedCommand[1]);
                int cow = int.Parse(splittedCommand[2]);
                int value = int.Parse(splittedCommand[3]);

                if (row < 0 || row >= matrix.Length || cow < 0 || cow >= matrix.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {

                    if (splittedCommand[0] == "Subtract")
                    {
                        matrix[row][cow] -= value;
                    }
                    else
                    {
                        matrix[row][cow] += value;
                    }

                }
                command = Console.ReadLine();
            }









            for (int rol = 0; rol < matrix.Length; rol++)
            {

                for (int col = 0; col < matrix.Length; col++)
                {

                    Console.Write(matrix[rol][col] + " ");
                }
                Console.WriteLine();
            }











        }
    }
}