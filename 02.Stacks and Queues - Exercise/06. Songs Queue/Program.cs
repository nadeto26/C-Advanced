namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songQueue = new Queue<string>(Console.ReadLine().Split(", ")); // All Over Again, Watch Me 

            while (songQueue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songQueue.Dequeue(); //пусками първата песен , смед това я изтриваме 
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4);// ще вземе всичко след 4 позиция

                    if (songQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(song);
                    }
                }
                else if (command == "Show") //принтираме всички песни
                {
                    Console.WriteLine(string.Join(", ", songQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
    }
