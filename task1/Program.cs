using System;

namespace StudentAssignment
{
    class Program
    {
        // The entry point of the application
        static void Main(string[] args)
        {
            // Initialize three different student objects using the CreateStudent helper method
            Student student1 = CreateStudent("1", StudentType.FullTime, "John", "Anderson");
            Student student2 = CreateStudent("2", StudentType.FullTime, "Karen", "Smith");
            Student student3 = CreateStudent("3", StudentType.PartTime, "Kevin", "Peters");

            Console.WriteLine("Assignment One");

            // Call the OutputStudent method to print each student's details
            OutputStudent(student1);
            OutputStudent(student2);
            OutputStudent(student3);

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();
        }

        // Factory method to create and populate a Student struct
        public static Student CreateStudent(string id, StudentType type, string firstName, string lastName)
        {
            Student newStudent = new Student();

            // If id is null, use "0"
            string validId = id ?? "0";
            // Convert the string ID into an integer for the struct field
            newStudent.id = int.Parse(validId);

            newStudent.type = type;
            // Fallback to "Unknown" if firstName is null
            newStudent.firstName = firstName ?? "Unknown";
            // Fallback to an empty string if lastName is null
            newStudent.lastName = lastName ?? "";

            return newStudent;
        }

        // Helper method to format and display student data
        public static void OutputStudent(Student s)
        {
            // :D3 formats the integer with leading zeros
            Console.WriteLine($"Student: {s.id:D3} {s.firstName} {s.lastName} ({s.type})");
        }
    }
}
