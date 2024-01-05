using System.Text;

namespace SoftUniKindergarten
{
    public class Child
    {
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private string parentName;

		public string ParentName
		{
			get { return parentName; }
			set { parentName = value; }
		}

		private string contactNumber;

		public string ContactNumber
		{
			get { return contactNumber; }
			set { contactNumber = value; }
		}
		public Child(string firstName, string lastName,int age, string parentName, string contactNumber)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			ParentName = parentName;
			ContactNumber = contactNumber;
		}
        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Child: {firstName} {lastName}, Age: {age}, Contact info: {parentName} - {contactNumber}");

            return sb.ToString().TrimEnd();
        }



    }
}
