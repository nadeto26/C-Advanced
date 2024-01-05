using System.Text;

namespace ShoeStore
{
    public class Shoe
    {
		private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		private double size;

		public double Size
		{
			get { return size; }
			set { size = value; }
		}

		private string material;

		public string Material
		{
			get { return material; }
			set { material = value; }
		}

		public Shoe (string brand, string type, double size ,string material)
		{
			Brand = brand;
			Type = type;
			Size = size;
			Material = material;
		}

        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Size {Size}, {Material} {Brand} {Type} shoe.");

            return sb.ToString().TrimEnd();

        }

        
			
		 



    }
}
