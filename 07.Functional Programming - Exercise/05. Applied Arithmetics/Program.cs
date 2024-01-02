namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //ADD: получаваме списък -> връщаме модифициран списък (всеки елемент + 1)
            Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();

            //MULTIPLY: получаваме списък -> връщаме модифиран списък (всеки елемент * 2)
            Func<List<int>, List<int>> multiply = list => list.Select(number => number *= 2).ToList();

            //SUBTRACT: получаваме списък -> връщаме модифициран списък (всеки елемент - 1)
            Func<List<int>, List<int>> subtract = list => list.Select(number => number -= 1).ToList();

            //PRINT: получаваме списък -> принтираме списъка
            Action<List<int>> print = list => Console.WriteLine(String.Join(" ", list));


            string command = Console.ReadLine();

            while (command != "end")
            {   //command = "add" или "multiply" или "subtract" или "print"
                switch (command)
                {
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
    }
}