using System;

namespace StudentAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = CreateStudent("1", StudentType.FullTime, "John", "Anderson");
            Student student2 = CreateStudent("2", StudentType.FullTime, "Karen", "Smith");
            Student student3 = CreateStudent("3", StudentType.PartTime, "Kevin", "Peters");

            Console.WriteLine("Assignment One");

            OutputStudent(student1);
            OutputStudent(student2);
            OutputStudent(student3);

            Console.ReadLine();
        }

        public static Student CreateStudent(string id, StudentType type, string firstName, string lastName)
        {
            Student newStudent = new Student();

            string validId = id ?? "0";
            newStudent.id = int.Parse(validId);

            newStudent.type = type;
            newStudent.firstName = firstName ?? "Unknown";
            newStudent.lastName = lastName ?? "";

            return newStudent;
        }

        public static void OutputStudent(Student s)
        {
            Console.WriteLine($"Student: {s.id:D3} {s.firstName} {s.lastName} ({s.type})");
        }
    }
}