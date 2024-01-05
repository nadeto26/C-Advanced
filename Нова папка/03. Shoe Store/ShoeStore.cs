using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int storageCapacity;

		public int  StorageCapacity
		{
			get { return storageCapacity; }
			set { storageCapacity = value; }
		}

		private List<Shoe> shoes;

		public List<Shoe> Shoes
		{
			get { return shoes; }
			set { shoes = value; }
		}

		public ShoeStore( string name, int storageCapacity)
		{
			Name = name;
			StorageCapacity = storageCapacity;
			shoes = new List<Shoe>();
		}

		public int Count => shoes.Count;

        public string AddShoe(Shoe shoe)
		{
			if (Shoes.Count == StorageCapacity)
			{
				return "No more space in the storage room.";

            }
			shoes.Add(shoe);
			return "Successfully added {shoeType} {shoeMaterial} pair of shoes to the store.";

        }

        public int RemoveShoes(string material)
		{
			int count = 0;
			for (int i=0; i< shoes.Count;i++)
			{
				if (shoes[i].Material == material.ToLower())
				{
					count++;
					shoes.RemoveAt(i--);

                }
			}


			return count; ;

		}

        public List<Shoe> GetShoesByType(string type)
		{
			List<Shoe> getshoesByType = new List<Shoe>();

            

			foreach( var shoe in shoes)
			{
				if (shoe.Type == type.ToLower())
				{
					getshoesByType.Add(shoe);
				}
			}

			return getshoesByType;
        }

		public Shoe GetShoeBySize(double size)
		=> shoes.First(x => x.Size == size);

		public string StockList(double size, string type)
		{
			List<Shoe> stockList = this.shoes.Where(x => x.Type == type && x.Size == size).ToList();
			StringBuilder sb = new StringBuilder();

			if (stockList.Count==0)
			{
				sb.AppendLine("No matches found!");
			}
			else
			{
				sb.AppendLine($"Stock list for size {size} - {type} shoes:");

				foreach( var stock in stockList)
				{
					sb.AppendLine(stock.ToString());
				}

            }
			return sb.ToString().TrimEnd();
			
		}



    }
}
