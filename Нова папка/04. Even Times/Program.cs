namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                {
                    result.Add(num, 1);
                }

            }
            var evenTimesNumber = result.First(kvp => kvp.Value % 2 == 0).Key;

            Console.WriteLine(evenTimesNumber);


        }
    }
}