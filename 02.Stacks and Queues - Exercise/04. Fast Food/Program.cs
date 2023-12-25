namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            List<int> orderList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            Queue<int> queue = new Queue<int>(orderList);

            Console.WriteLine(queue.Max());

            int countOrders = queue.Count;
            for (int i = 1; i <= countOrders; i++)
            {
                // правим проверка дали храната ще покрие поръчката 
                if (totalFood >= queue.Peek())  // peek взима последното число
                {
                    totalFood -= queue.Peek(); // изпълнявам поръчката
                    queue.Dequeue(); // след като сме изпълнили поръчката я изтриваме
                }
                else
                {
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: " + string.Join(" ", queue));
            }
        }
    }
}