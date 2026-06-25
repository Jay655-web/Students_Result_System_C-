static class StudentReportPrinter
{
    public static void ViewStudentReport(List<Student> students, string[] courseNames)
    {
        Console.WriteLine("====== STUDENT RESULTS REPORT ======");

        foreach (Student s in students)
        {
            Console.WriteLine($"\nStudent Name: {s.FullName}");
            Console.WriteLine($"Student ID: {s.StudentId}");
            Console.WriteLine($"Programme: {s.Programme}");
            Console.WriteLine($"Level: {s.Level}");

            for (int i = 0; i < s.Scores.Length; i++)
            {
                Console.WriteLine($"{courseNames[i]}: {s.Scores[i]}");
            }

            Console.WriteLine($"\nTotal Score: {s.TotalScore}");
            Console.WriteLine($"Average Score: {s.AverageScore:F1}");
            Console.WriteLine($"Grade: {s.Grade}");
            Console.WriteLine($"Status: {s.Status}");
        }
    }
}