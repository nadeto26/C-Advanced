namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string input = Console.ReadLine();


            while (input != "END")
            {
                string[] splittedInput = input.Split(", ");

                string command = splittedInput[0];// in or out 

                string registration = splittedInput[1];

                if (command == "IN")
                {
                    cars.Add(registration);
                }
                else
                {
                    cars.Remove(registration);
                }



                input = Console.ReadLine();
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }

        }
    }
}