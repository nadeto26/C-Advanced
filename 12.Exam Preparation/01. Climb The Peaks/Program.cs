namespace _01._Climb_The_Peaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> peaks = new()
{
    { "Vihren",80 },
    {"Kutelo",90 },
    {"Banski Suhodol",100 },
    {"Polezhan",60 },
    {"Kamenitza",70 }

};

            Queue<string> peaksNames = new(new List<string> { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });

            Stack<int> foodPortions =
                new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> staminaQuentities =
                new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            List<string> conqueredPeaks = new List<string>();

            while (foodPortions.Any() && staminaQuentities.Any() && peaksNames.Any())
            {
                int foodPortion = foodPortions.Pop();
                int staminaQuentitie = staminaQuentities.Dequeue();
                int peakDifficulty = peaks[peaksNames.Peek()]; // вземаме стойността - value - то на дикшинарито 

                if (foodPortion + staminaQuentitie >= peakDifficulty)
                {
                    conqueredPeaks.Add(peaksNames.Dequeue()); // и го взимам и го премахвам 

                }


            }

            if (peaksNames.Any()) // ние премахваме от тях , а не от дикшанарито 
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }
            else
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }

            if (conqueredPeaks.Any())
            {
                Console.WriteLine("Conquered peaks:");

                foreach (var con in conqueredPeaks)
                {
                    Console.WriteLine(con);
                }
            }



        }
    }
}