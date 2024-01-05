namespace _02._Navy_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int sRow = 0;
            int sCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'S')
                    {
                        matrix[row, col] = '-';
                        sRow = row;
                        sCol = col;
                    }
                }
            }

            int mine = 0;
            int cruiser = 3;

            while (true)
            {
                string directions = Console.ReadLine();

                if (directions == "left")
                {
                    if (matrix[sRow, sCol - 1] == '*')
                    {
                        mine++;
                        matrix[sRow, sCol] = '-';
                        if (mine == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{sRow}, {sCol - 1}]!");
                            break;
                        }
                    }
                    else if (matrix[sRow, sCol - 1] == 'C')
                    {
                        matrix[sRow, sCol] = '-';
                        cruiser--;
                        if (cruiser == 0)
                        {

                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                    }
                    sCol--;
                    matrix[sRow, sCol] = 'S';

                }
                else if (directions == "right")
                {
                    if (matrix[sRow, sCol + 1] == '*')
                    {
                        mine++;
                        matrix[sRow, sCol] = '-';
                        if (mine == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{sRow}, {sCol - 1}]!");
                            break;
                        }
                    }
                    else if (matrix[sRow, sCol + 1] == 'C')
                    {
                        matrix[sRow, sCol] = '-';
                        cruiser--;
                        if (cruiser == 0)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                    }
                    sCol++;
                    matrix[sRow, sCol] = 'S';

                }
                else if (directions == "up")
                {
                    if (matrix[sRow - 1, sCol] == '*')
                    {
                        mine++;
                        matrix[sRow, sCol] = '-';
                        if (mine == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{sRow}, {sCol - 1}]!");
                            break;
                        }
                    }
                    else if (matrix[sRow - 1, sCol] == 'C')
                    {
                        matrix[sRow, sCol] = '-';
                        cruiser--;
                        if (cruiser == 0)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                    }
                    sRow--;
                    matrix[sRow, sCol] = 'S';

                }
                else if (directions == "down")
                {
                    if (matrix[sRow + 1, sCol] == '*')
                    {
                        mine++;
                        matrix[sRow, sCol] = '-';
                        if (mine == 3)
                        {
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{sRow}, {sCol - 1}]!");
                            break;
                        }
                    }
                    else if (matrix[sRow + 1, sCol] == 'C')
                    {
                        matrix[sRow, sCol] = '-';
                        cruiser--;
                        if (cruiser == 0)
                        {
                            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                    }
                    sRow++;
                    matrix[sRow, sCol] = 'S';
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++) // обхождаме и  я прочитаме  матрицата 
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }


        }
    }
}