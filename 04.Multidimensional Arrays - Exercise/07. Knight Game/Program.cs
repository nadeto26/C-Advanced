namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()); //редовете (матрица)

            if (size < 0)
            {
                Console.WriteLine(0); // няма как да се вземат 

                return;
            }

            char[,] matrix = new char[size, size];

            // четем си матрицата 
            for (int row = 0; row < size; row++)
            {
                string chars = Console.ReadLine();
                for (int cow = 0; cow < size; cow++)
                {
                    matrix[row, cow] = chars[cow];
                }
            }
            int knightRemoved = 0;

            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;


                for (int row = 0; row < size; row++)
                {

                    for (int cow = 0; cow < size; cow++)
                    {
                        if (matrix[row, cow] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, cow, size, matrix);

                            if (countMostAttacking < attackedKnights)
                            {
                                countMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = cow;
                            }
                        }
                    }
                }

                if (colMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    knightRemoved++;
                }

            }

            Console.WriteLine(knightRemoved);

            static int CountAttackedKnights(int row, int col, int size, char[,] matrix)
            {
                int attackedKnights = 0;

                //horizontal left-up
                if (ValidateCell(row - 1, col - 2, size))
                {
                    if (matrix[row - 1, col - 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal left-down
                if (ValidateCell(row + 1, col - 2, size))
                {
                    if (matrix[row + 1, col - 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal right-up
                if (ValidateCell(row - 1, col + 2, size))
                {
                    if (matrix[row - 1, col + 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal right-down
                if (ValidateCell(row + 1, col + 2, size))
                {
                    if (matrix[row + 1, col + 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal up-left
                if (ValidateCell(row - 2, col - 1, size))
                {
                    if (matrix[row - 2, col - 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal up-right
                if (ValidateCell(row - 2, col + 1, size))
                {
                    if (matrix[row - 2, col + 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal down-left
                if (ValidateCell(row + 2, col - 1, size))
                {
                    if (matrix[row + 2, col - 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal down-right
                if (ValidateCell(row + 2, col + 1, size))
                {
                    if (matrix[row + 2, col + 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                return attackedKnights;
            }

            static bool ValidateCell(int row, int col, int size)
            {
                return
                    row >= 0
                    && row < size
                    && col >= 0
                    && col < size;
            }

        }
    }
    }
}