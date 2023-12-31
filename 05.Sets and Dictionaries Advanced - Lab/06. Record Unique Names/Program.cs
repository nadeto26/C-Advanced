namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> list = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                list.Add(name);

            }


            foreach (var nam in list)
            {
                Console.WriteLine(nam);
            }

        }
    }
}