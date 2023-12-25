using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // броя на командите 

            StringBuilder text = new StringBuilder();// празен

            Stack<string> textHistory = new Stack<string>();

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();



                if (command.StartsWith("1"))
                {
                    textHistory.Push(text.ToString());

                    string textToADD = command.Split()[1];
                    text.Append(textToADD);


                }
                else if (command.StartsWith("2"))
                {
                    textHistory.Push(text.ToString());
                    int count = int.Parse(command.Split()[1]);

                    text.Remove(text.Length - count, count);
                }
                else if (command.StartsWith("3"))
                {
                    int index = int.Parse(command.Split()[1]); //взимаме поредния номер на буквата 
                    Console.WriteLine(text[index - 1]);
                }
                else
                {
                    text = new StringBuilder(textHistory.Pop());
                }

            }
        }
    }
}