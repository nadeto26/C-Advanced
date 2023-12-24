namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End") // прекратяваме цикъла и отпечваме броя на останалите клиенти 
                {
                    Console.WriteLine($"{string.Join(" ", queue.Count)} people remaining.");
                    break;

                }
                else if (name == "Paid") // принтираме имената на клиентите от опашката , след това трябва да изпразним опашката!!!!
                {
                    foreach (string namez in queue)
                    {
                        Console.WriteLine(string.Join(" ", namez));
                    }


                    for (int i = 0 - 1; i <= queue.Count; i++)
                    {

                        queue.Dequeue();
                    }



                }
                else
                {
                    queue.Enqueue(name);
                }
            }
    }
}