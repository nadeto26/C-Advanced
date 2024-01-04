using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;

namespace Zoo
{
    public class Zoo
    {

        //полетата и пропъртис 
        private List<Animal> animals;

        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        // конструктор 

        public Zoo(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            animals = new List<Animal>();
        }

        //методите 

        public string AddAnimal(Animal animal)
        {
            if (animal == null || animals.Count<0)
            {
                return "Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            else if (animals.Count>Capacity)
            {
                return "The zoo is full.";
            }

            animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        
            =>animals.RemoveAll(a => a.Species == species);

        public List<Animal> GetAnimalsByDiet(string diet)

            => animals.Where(a => a.Diet == diet).ToList();


        public Animal GetAnimalByWeight(double weight)

          => animals.FirstOrDefault(s => s.Weight == weight);


        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            IEnumerable<Animal> animalList = 
                animals.Where(s => s.Length >=minimumLength && s.Length<=maximumLength).ToList();
            StringBuilder st = new StringBuilder();

            if (animalList.Any())
            {
                st.AppendLine($"There are {animalList.Count()} animals with a length between" +
                    $" {minimumLength} and {maximumLength} meters.");
            }
            
            

                

            
            return st.ToString().Trim();



        }




    }
}
