using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
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

		private List<Child> registry;

        public List<Child> Registry
        {
			get { return registry; }
			set { registry = value; }
		}

		public Kindergarten( string name, int capacity)
		{
			Name = name;
			Capacity = capacity;
			registry = new List<Child>();
		}

		public bool AddChild(Child child)
		{
			if (registry.Count< capacity)
			{
				registry.Add(child);
				return true;
			}
			return false;
		}

		public bool RemoveChild(string childFullName)
		{
			var removed = registry.Find(c => childFullName == $"{c.FirstName} {c.LastName}");

			if (removed == null)
			{
				return false;
			}
			registry.Remove(removed);
			return true;
        }

		public int ChildrenCount => registry.Count;

		public Child GetChild(string childFullName)
		{
            return  registry.FirstOrDefault(c => childFullName == $"{c.FirstName} {c.LastName}");
		  
        }

		public string RegistryReport()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Registered children in {Name}:");

			foreach(Child child in registry.OrderByDescending(x=>x.Age).OrderBy(x=>x.LastName).OrderBy(x=>x.FirstName))
			{
				sb.AppendLine(child.ToString());
			}

			return sb.ToString().TrimEnd();
		}







    }
}
