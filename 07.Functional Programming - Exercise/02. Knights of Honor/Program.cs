namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();

            Action<string> addPrefix = name => Console.WriteLine("Sir " + name);

            foreach (var name in names)
            {
                addPrefix(name);
            }
        }
    }
}