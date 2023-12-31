namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(n => n)
 .ToArray();
            int count = integers.Length >= 3 ? 3 : integers.Length;
            for (int i = 0; i < count; i++)
                Console.Write($"{integers[i]} ");
        }
    }
}