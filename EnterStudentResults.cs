static class StudentResultHelpers
{
    public static void EnterStudentResults(List<Student> students)
    {
        Student s = new Student();

        Console.Write("Enter Full name: ");
        s.FullName = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Student ID: ");
        s.StudentId = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Programme: ");
        s.Programme = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Level: ");
        s.Level = Console.ReadLine() ?? string.Empty;

        string[] courseNames =
        {
            "Programming with C#",
            "Database Systems",
            "Computer Networks",
            "Web Development",
            "Mathematics for Computing"
        };

        for (int i = 0; i < courseNames.Length; i++)
        {
            int score;
            bool valid = false;
            do
            {
                Console.Write($"Enter score for {courseNames[i]}: ");
                valid = int.TryParse(Console.ReadLine(), out score);

                if (!valid || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid Score. Score must be between 0 and 100.");
                    valid = false;
                }
            } while (!valid);

            s.Scores[i] = score;
        }

        StudentResultCalculator.CalculateResults(s);
        students.Add(s);
    }
}