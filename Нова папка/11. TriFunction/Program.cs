namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").ToList();

            Console.WriteLine(names.First(name => name.Select(symbol => (int)symbol).Sum() >= n));
        }
    }
}