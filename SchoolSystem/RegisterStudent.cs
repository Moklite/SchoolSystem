using SchoolSystem.Model;
using System;

namespace SchoolSystem
{
    public static class RegisterStudent
    {
        public static void RegisterStudentDetails(Student student)
        {
            student.Id = Guid.NewGuid().ToString();

            Console.WriteLine("Please input student name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Please input student class: ");
            student.Class = Console.ReadLine();

            DataStorage.students.Add(student);
        }

    }
}
