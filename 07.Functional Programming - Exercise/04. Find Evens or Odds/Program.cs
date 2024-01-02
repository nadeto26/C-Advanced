namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> addPrefix = numbers => numbers.Min();

            string input = Console.ReadLine();

            int startNumber = int.Parse(input.Split()[0]);

            int endNumber = int.Parse(input.Split()[1]);


            List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = null;

            string command = Console.ReadLine();

            if (command == "even")
            {
                predicate = number => number % 2 == 0;
            }
            else
            {
                predicate = number => number % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
        }
    }
}