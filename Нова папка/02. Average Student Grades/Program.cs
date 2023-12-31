namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<string, List<decimal>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = decimal.Parse(tokens[1]);
                if (!grades.ContainsKey(name))
                    grades[name] = new List<decimal>();
                grades[name].Add(grade);
            }
            foreach (var (name, studentsGrades) in grades)
            {
                var average = studentGrades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                    Console.Write($"{grade:f2} ");
                Console.WriteLine($"(avg: {average:f2})");
            }

        }
    }
}