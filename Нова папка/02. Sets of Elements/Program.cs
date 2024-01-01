namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new(); // първите числа
            HashSet<int> secondSet = new();

            int[] count = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); // двете числа

            for (int i = 0; i < count[0]; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                firstSet.Add(numbers);
            }

            for (int i = 0; i < count[1]; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                secondSet.Add(numbers);
            }

            firstSet.IntersectWith(secondSet); // ще ни даде общото между двете дикшанарита 

            Console.WriteLine(string.Join(" ", firstSet));



        }
    }
}