namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            SortedDictionary<char, int> charCounts = new();

            foreach (var ch in input)
            {
                if (!charCounts.ContainsKey(ch))
                {
                    charCounts.Add(ch, 0);
                }

                charCounts[ch]++;
            }

            foreach (var ch in charCounts)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s ");
            }

        }
    }
}