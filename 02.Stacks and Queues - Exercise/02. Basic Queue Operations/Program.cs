namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); //5 2 13 

            int n = numbers[0]; // броя на числата , които ще добавим
            int s = numbers[1]; // броя на елементите , които ще изтрием
            int x = numbers[2];

            Queue<int> queue = new Queue<int>(); // празен стек 

            int[] numberList = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();//1 13 45 32 4 

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numberList[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }



        }
    }
}