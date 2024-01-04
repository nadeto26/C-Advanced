using System.Text;

namespace Zoo
{
    public class Animal
    {

		// полета и пропъртис 

		private string species;

		public string Species
		{
			get { return species; }
			set { species = value; }
		}

		private string diet;

		public string Diet
		{
			get { return diet; }
			set { diet = value; }
		}

		private double weight;

		public double Weight
		{
			get { return  weight; }
			set { weight = value; }
		}

		private double length;

		public double Length
		{
			get { return length; }
			set { length = value; }
		}

		// конструктори 

		public Animal (string spesies , string diet , double weight, double length)
		{
			this.Species = spesies;
			this.Diet = diet;
			this.Weight = weight;
			this.Length = length;
		}

        // ToString

        public override string ToString()
        {

			StringBuilder st = new StringBuilder();

			st.Append($"The {species} is a {diet} and weighs {weight} kg.");

            return st.ToString().Trim();
        }


    }
}
