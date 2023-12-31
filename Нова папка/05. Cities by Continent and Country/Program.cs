namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, string>> dic = new Dictionary<string, Dictionary<string, string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] splittedCommand = Console.ReadLine().Split(" ");

                string countinent = splittedCommand[0];
                string country = splittedCommand[1];
                string city = splittedCommand[2];

                if (!dic.ContainsKey(countinent))
                {
                    dic.Add(countinent, new Dictionary<string, string>());
                }
                if (!dic.ContainsKey(countinent))
                {
                    dic[countinent].Add(country, city);
                }

                dic[countinent][country] = (city);


            }





            foreach (var (countinentName, countries) in dic)
            {
                Console.WriteLine($"{countinentName}: ");

                foreach (var (countriName, cities) in countries)
                {
                    Console.WriteLine($"  {countriName} -> {string.Join(", ", cities)}");
                }
            }

        }
    }
}