namespace _02._Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int mCol = 0;
            int mRow = 0;

            for (int rol = 0; rol < matrix.GetLength(1); rol++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rol, col] = input[col];

                    if (matrix[rol, col] == 'M')
                    {
                        mCol = col;
                        mRow = rol;
                        matrix[rol, col] = '-';
                    }
                }
            }

            int points = 0;

            string direction = Console.ReadLine();

            while (direction != "End")
            {
                if (direction == "up")
                {
                    if (IsValid(matrix, mRow, mCol - 1))
                    {
                        if (matrix[mRow, mCol - 1] == 'S')
                        {
                            points -= 3;
                            matrix[mRow, mCol] = '-';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'S')
                                    {
                                        //teleportation = true;
                                        mRow = i;
                                        mCol = j;
                                        matrix[mRow, mCol] = '-';
                                    }
                                }
                            }


                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                            continue;
                        }
                        mCol--;
                        matrix[mRow, mCol] = 'M';


                    }
                    else if (direction == "down")
                    {
                        if (IsValid(matrix, mRow, mCol + 1))
                        {
                            if (matrix[mRow, mCol + 1] == 'S')
                            {
                                points -= 3;
                                matrix[mRow, mCol] = '-';
                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        if (matrix[i, j] == 'S')
                                        {
                                            //teleportation = true;
                                            mRow = i;
                                            mCol = j;
                                            matrix[mRow, mCol] = '-';
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                                continue;
                            }
                            mCol++;
                            matrix[mRow, mCol] = 'M';
                        }
                        else if (direction == "right")
                        {

                            if (IsValid(matrix, mRow + 1, mCol))
                            {
                                if (matrix[mRow + 1, mCol] == 'S')
                                {
                                    points -= 3;
                                    matrix[mRow, mCol] = '-';
                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (matrix[i, j] == 'S')
                                            {
                                                //teleportation = true;
                                                mRow = i;
                                                mCol = j;
                                                matrix[mRow, mCol] = '-';
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Don't try to escape the playing field!");
                                    continue;
                                }
                                mRow++;
                                matrix[mRow, mCol] = 'M';
                            }
                        }
                        else if (direction == "left")
                        {

                            if (IsValid(matrix, mRow - 1, mCol))
                            {
                                if (matrix[mRow - 1, mCol] == 'S')
                                {
                                    points -= 3;
                                    matrix[mRow, mCol] = '-';
                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (matrix[i, j] == 'S')
                                            {
                                                //teleportation = true;
                                                mRow = i;
                                                mCol = j;
                                                matrix[mRow, mCol] = '-';
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Don't try to escape the playing field!");
                                    continue;
                                }
                                mRow--;
                                matrix[mRow, mCol] = 'M';
                            }
                        }


                        direction = Console.ReadLine();
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }




                    bool IsValid(char[,] matrix, int row, int col)
                    {
                        return row >= 0 && row < matrix.GetLength(0)
                           && col >= 0 && col < matrix.GetLength(1);
                    }
                }
            }

        }
    }
}