namespace LINQ_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mohammed", 20, "Male", 3.6));
            students.Add(new Student("Maha", 19, "Female", 4.0));
            students.Add(new Student("Saeed", 21, "Male", 3.0));
            students.Add(new Student("Reem", 22, "Female", 3.8));
            students.Add(new Student("Ahmed", 23, "Male", 3.2));

            Console.WriteLine("List of all students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nMale students with a GPA greater than 3.5:");
            foreach (Student student in students.Where(s => s.Gender == "Male" && s.GPA > 3.5))
            {
                Console.WriteLine(student);
            }

            double averageGPA = students.Where(s => s.Gender == "Female").Average(s => s.GPA);
            Console.WriteLine("\nThe average GPA of all female students is: {0}", averageGPA);

            Console.WriteLine("\nThe names of the top three students with the highest GPA are:");
            var topThreeStudents = students.OrderByDescending(s => s.GPA).Take(3);
            foreach (Student student in topThreeStudents)
            {
                Console.WriteLine(student.Name);
            }

            int studentIndex = students.FindIndex(s => s.Name == "Ahmed");
            students[studentIndex].GPA = 4.0;
            Console.WriteLine("\nThe GPA of Ahmed has been updated to 4.0");

            string studentName = "Saeed";
            students.Remove(students.FirstOrDefault(s => s.Name == studentName));
            Console.WriteLine("\nThe student named {0} has been removed from the list", studentName);
        }
    }
}