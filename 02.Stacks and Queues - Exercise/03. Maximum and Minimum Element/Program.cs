namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // броя на командите 

            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();



                if (command.StartsWith("1")) // x – Push the element x into the stack. 
                {
                    int element = int.Parse(command.Split()[1]);

                    stack.Push(element);


                }
                else if (command.StartsWith("2")) //2	– Delete the element present at the top of the stack. 
                {
                    stack.Pop();
                }
                else if (command.StartsWith("3"))
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command.StartsWith("4"))
                {
                    Console.WriteLine(stack.Min());
                }

            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}