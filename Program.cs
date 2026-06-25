using System;
using System.Collections.Generic;

List<Student> students = new List<Student>();
bool running = true;

while (running)
{
    Console.WriteLine("===== STUDENT RESULTS PROCESSING SYSTEM =====");
    Console.WriteLine("1. Enter Student Results");
    Console.WriteLine("2. View Student Report");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            StudentResultHelpers.EnterStudentResults(students);
            break;
        case "2":
            string[] courseNames = { "Programming with C#", "Database Systems", "Computer Networks", "Web Development", "Mathematics for Computing" };
            StudentReportPrinter.ViewStudentReport(students, courseNames);
            break;
        case "3":
            Console.WriteLine("Thank you for using the Student Results Processing System.");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
