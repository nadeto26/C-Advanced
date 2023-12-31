namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Dictionary<double, int> num = new Dictionary<double, int>();

            // double -> ключа int -> колко пъти сме срещнали числото 


            foreach (var item in numbers)
            {
                if (num.ContainsKey(item))
                {
                    num[item]++;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (var item in num)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }


        }
    }
}