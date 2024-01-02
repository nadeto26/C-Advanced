namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ").ToList();

            List<string> list = new List<string>();

            foreach (string name in names)
            {
                Predicate<string> predicate = name => name.Length <= n;

                if (!predicate(name))
                {
                    break;
                }
                else
                {
                    list.Add(name);
                }
            }

            foreach (string li in list)

            {
                Console.WriteLine(li);
            }
        }
    }
}