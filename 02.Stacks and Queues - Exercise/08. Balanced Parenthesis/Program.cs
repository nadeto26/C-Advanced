namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);
            Queue<char> queue = new Queue<char>(input);

            while (stack.Count > 0)
            {
                char firstStack = stack.Peek();
                char firstQueue = queue.Peek();

                if (firstStack == '{' && firstQueue == '}')
                {
                    stack.Pop();
                    queue.Dequeue();
                    Console.WriteLine("Yes");
                    continue;

                }
                else
                {
                    Console.WriteLine("NO");
                    break;
                }

                if (firstStack == '[' && firstQueue == ']')
                {
                    stack.Pop();
                    queue.Dequeue();
                    Console.WriteLine("Yes");
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    break;
                }
                if (firstStack == '(' && firstQueue == ')')
                {
                    stack.Pop();
                    queue.Dequeue();
                    Console.WriteLine("Yes");
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.WriteLine("Yes");
                    break;
                }
            }
        }
    }
}