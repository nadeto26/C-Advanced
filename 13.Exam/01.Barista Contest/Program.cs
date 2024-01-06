namespace _01._Barista_Contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffes = new Queue<int>
(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Stack<int> milks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            SortedDictionary<string, int> dic = new SortedDictionary<string, int>
{
    {"Cortado" ,0},
    {"Espresso",0},
    {"Capuccino",0},
    {"Americano",0},
    {"Latte",0},

};


            while (coffes.Any() && milks.Any())
            {
                int coffe = coffes.Peek();
                int milk = milks.Peek();

                int sum = milk + coffe;

                if (sum == 50)
                {
                    dic["Cortado"]++;
                    coffes.Dequeue();
                    milks.Pop();
                }
                else if (sum == 75)
                {
                    dic["Espresso"]++;
                    coffes.Dequeue();
                    milks.Pop();
                }

                else if (sum == 100)
                {
                    dic["Capuccino"]++;
                    coffes.Dequeue();
                    milks.Pop();
                }
                else if (sum == 150)
                {
                    dic["Americano"]++;
                    coffes.Dequeue();
                    milks.Pop();
                }
                else if (sum == 200)
                {
                    dic["Latte"]++;
                    coffes.Dequeue();
                    milks.Pop();
                }
                else
                {
                    coffes.Dequeue();
                    int value = milks.Pop() - 5;
                    milks.Push(value);
                }



            }
            var milkleft = String.Join(", ", milks);
            var coffeLeft = String.Join(", ", coffes);

            if (milks.Count <= 0 && coffes.Count <= 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }



            if (!coffes.Any())
            {
                Console.WriteLine("Coffee left: none");
            }
            else
            {
                Console.WriteLine($"Coffee left: {coffeLeft}");
            }




            if (!milks.Any())
            {
                Console.WriteLine("Milk left: none");
            }

            else
            {
                Console.WriteLine($"Milk left: {milkleft}");
            }



            foreach (var d in dic.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (d.Value > 0)
                {
                    Console.WriteLine($"{d.Key}: {d.Value}");
                }

            }
        }
    }
}