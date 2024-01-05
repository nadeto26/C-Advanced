namespace _02._Blind_Man_s_Buff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int roll = size[0];
            int coll = size[1];

            char[,] matrix = new char[roll, coll];

            int bRol = 0;
            int bCol = 0;

            for (int rol = 0; rol < matrix.GetLength(0); rol++)
            {
                char[] input = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rol, col] = input[col];

                    if (matrix[rol, col] == 'B')
                    {
                        bRol = rol;
                        bCol = col;
                    }


                }
            }

            string command = Console.ReadLine();
            int moves = 0;
            int opponent = 0;

            while (command != "Finish")
            {
                if (command == "left")
                {
                    if (IsValid(matrix, bRol, bCol - 1))
                    {
                        matrix[bRol, bCol] = '-';
                        moves++;
                        if (matrix[bRol, bCol - 1] == 'P')
                        {
                            opponent++;
                        }
                        bCol--;
                        matrix[bRol, bCol] = 'B';
                    }
                }
                else if (command == "right")
                {
                    if (IsValid(matrix, bRol, bCol + 1))
                    {
                        matrix[bRol, bCol] = '-';
                        moves++;
                        if (matrix[bRol, bCol + 1] == 'P')
                        {
                            opponent++;
                        }
                        bCol++;
                        matrix[bRol, bCol] = 'B';
                    }
                }
                else if (command == "up")
                {
                    if (IsValid(matrix, bRol - 1, bCol))
                    {
                        matrix[bRol, bCol] = '-';
                        moves++;
                        if (matrix[bRol - 1, bCol] == 'P')
                        {
                            opponent++;
                        }
                        bRol--;
                        matrix[bRol, bCol] = 'B';
                    }
                }
                else if (command == "down")
                {
                    if (IsValid(matrix, bRol + 1, bCol))
                    {
                        matrix[bRol, bCol] = '-';
                        moves++;
                        if (matrix[bRol + 1, bCol] == 'P')
                        {
                            opponent++;
                        }
                        bRol++;
                        matrix[bRol, bCol] = 'B';
                    }
                }



                command = Console.ReadLine();
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {opponent} Moves made: {moves}");

            bool IsValid(char[,] matrix, int bRol, int bCol)
            {
                return bRol >= 0 && bRol < matrix.GetLength(0)
                    && bCol >= 0 && bCol < matrix.GetLength(1)
                    && matrix[bRol, bCol] != 'O';
            }
        }
    }
}