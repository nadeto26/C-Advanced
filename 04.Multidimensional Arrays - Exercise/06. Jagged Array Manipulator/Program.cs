namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine()); //редовете 

            int[][] jaggedArray = new int[rows][]; // при назъбините знаем само редовете 

            for (int row = 0; row < rows; rows++)
            {
                int[] cols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                jaggedArray[row] = cols;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {

                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }

                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;

                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {

                        jaggedArray[row + 1][col] /= 2;
                    }

                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] spittedCommand = command.Split(' ');

                int row = int.Parse(spittedCommand[1]);

                int column = int.Parse(spittedCommand[2]);

                int value = int.Parse(spittedCommand[3]);

                if (row >= 0 && row <= jaggedArray.Length && column >= 0 && column <= jaggedArray[row].Length)
                {
                    if (spittedCommand[0] == "Add")
                    {
                        jaggedArray[row][column] += value;
                    }
                    else
                    {
                        jaggedArray[row][column] -= value;
                    }
                }







                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }



        }
    }
}