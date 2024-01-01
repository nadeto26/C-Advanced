namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> result = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] splittedCommand = Console.ReadLine().Split(" ");

                foreach (var command in splittedCommand)
                {
                    result.Add((command));
                }
            }

            foreach (var re in result)
            {
                Console.Write(re + " ");
            }
        }
    }
}