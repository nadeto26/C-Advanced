using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
		private string name;

		public string Name 
		{
			get { return name; }
			set { name = value; }
		}

		private int neededRenovators;

		public int NeededRenovators
		{
			get { return neededRenovators; }
			set { neededRenovators = value; }
		}

		private string project;

		public string Project
		{
			get { return project; }
			set { project = value; }
		}

		private List<Renovator> renovators;

		public List<Renovator> Renovators  
		{
			get { return renovators; }
			set { renovators = value; }
		}
		public Catalog (string name , int neededRenovators,string project)
		{
			Name = name;
			Project = project;
			NeededRenovators = neededRenovators;
			renovators = new List<Renovator>();
		}


		public int Count => renovators.Count;

        public string AddRenovator(Renovator renovator)
		{
			if (renovator.Name == null || renovator.Name == string.Empty && renovator.Type == null || renovator.Type == string.Empty)
			{
				return "Invalid renovator's information.";

            }
			else if  (this.Count == this.NeededRenovators)
			{
				return "Renovators are no more needed.";

            }
			else if (renovator.Rate >  350)
			{
				return "Invalid renovator's rate.";

            }
			renovators.Add(renovator);
			return $"Successfully added {renovator.Name} to the catalog.";

        }

		public bool RemoveRenovator(string name)
		{
			var remove = renovators.FirstOrDefault(x => x.Name == name);

			if (remove == null)
			{
				return false;
			}
			return this.renovators.Remove(remove);
		}

        public int RemoveRenovatorBySpecialty(string type)
		{
			int result = 0;
            while (this.Renovators.FirstOrDefault(x => x.Type == type) != null)
            {
                var targetRenovator = this.Renovators.FirstOrDefault(x => x.Type == type);
                this.renovators.Remove(targetRenovator);
                result++;
            }
            return result;

        }

        public Renovator HireRenovator(string name)
		{
            var targetRenovator = this.Renovators.FirstOrDefault(x => x.Name == name);
			if (targetRenovator == null)
			{
				return null;
			}
			this.Renovators.FirstOrDefault(x => x.Name == name).Hired = true;
			return targetRenovator;
        }

        public List<Renovator> PayRenovators(int days)
		{
			List<Renovator> payRenovators = new List<Renovator>();

			foreach( var pay in payRenovators.Where(x=>x.Days>=days))
			{
				payRenovators.Add(pay);
			}
			return payRenovators;
		}

		public string Report()
		{
            var sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");
            foreach (var item in this.Renovators.Where(x => x.Hired == false).Where(x => x.Paid == false))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }

}

