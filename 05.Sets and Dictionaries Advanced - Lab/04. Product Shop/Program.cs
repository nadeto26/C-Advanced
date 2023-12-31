namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] splittedCommand = command.Split(", ");

                string shop = splittedCommand[0];
                string product = splittedCommand[1];
                double price = double.Parse(splittedCommand[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops.ContainsKey(shop))
                {
                    shops[shop].Add(product, price);
                }
                shops[shop][product] = price;





                command = Console.ReadLine();
            }

            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (shop, products) in shops)
            {
                Console.WriteLine($"{shop}-> ");

                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price} ");
                }
            }

        }
    }
}