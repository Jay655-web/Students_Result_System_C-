using System.Collections.Generic;

List<Student>students = newList<Student>();
bool running = true;

while(running)
{
    Console.WriteLine("===== STUDENT RESULTS PROCESSING SYSTEM =====");
    Console.WriteLine("1. Enter Student Results");
    Console.WriteLine("2. View Student Report");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            EnterStudentResults(students);
            break;
        case "2":
            ViewStudentReport(students);
            break;
        case "3":
            running = false;
            Console.WriteLine("Thank you for using the Student Results Processing System.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}