namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> colorClothes = new();

            // string -> цвета 
            // Dictionary <string > -> дреха 
            // int -> броя 

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];

                if (!colorClothes.ContainsKey(color))
                {
                    colorClothes.Add(color, new Dictionary<string, int>()); // инициализираме си задължителто първо речника 

                }

                for (int j = 1; j < tokens.Length; j++)
                {
                    string currentWear = tokens[j]; // така ще вземим абсолютно вкички дрехи 

                    if (!colorClothes[color].ContainsKey(currentWear)) // ако речника не съдържа дрехата от самия цвят я добавяме 
                    {
                        colorClothes[color].Add(currentWear, 0);
                    }
                    colorClothes[color][currentWear]++;
                }

            }

            // сега получаваме това , което вече имаме

            string[] findClothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in colorClothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var wearCont in color.Value) // взимамеа от речника облеклото и бройката 
                {
                    string printItem = $"* {wearCont.Key} - {wearCont.Value}";

                    if (color.Key == findClothes[0] && wearCont.Key == findClothes[1])
                    {
                        printItem += " (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}