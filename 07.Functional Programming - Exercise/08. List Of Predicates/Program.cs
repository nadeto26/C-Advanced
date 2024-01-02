namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> deviders = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            List<int> list = new List<int>();
            foreach (int number in numbers)
            {
                bool isDivisible = true;
                foreach (int dec in deviders)
                {
                    Predicate<int> isDevesir = number => number % dec == 0;

                    if (!isDevesir(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    list.Add(number);
                }
            }


            Console.WriteLine(string.Join(" ", list));
        }
    }
}