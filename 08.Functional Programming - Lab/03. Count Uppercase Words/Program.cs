namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = n => n[0] == n.ToUpper()[0];

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(input => predicate(input)).ToArray();

            foreach (var inputItem in input)
            {
                Console.WriteLine(inputItem);
            }
        }
    }
}