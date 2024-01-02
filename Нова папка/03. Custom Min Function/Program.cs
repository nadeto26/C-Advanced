namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Func<List<int>, int> addPrefix = numbers => numbers.Min();

            Console.WriteLine(addPrefix(numbers));
        }
    }
}