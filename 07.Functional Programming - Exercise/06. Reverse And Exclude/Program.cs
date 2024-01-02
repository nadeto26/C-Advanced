namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int delitel = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            foreach (int num in numbers)
            {
                Predicate<int> predicate = num => num % delitel == 0;

                if (!predicate(num))
                {
                    list.Add(num);
                }
            }
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}