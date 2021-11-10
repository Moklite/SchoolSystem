using SchoolSystem.Model;
using System;
using System.Text.RegularExpressions;

namespace SchoolSystem
{
    public static class Authentication
    {

        public static void Register(Teacher teacher)
        {

            teacher.Id = Guid.NewGuid().ToString();

            Console.WriteLine("Please input your name:");
            teacher.Name = Console.ReadLine();
            var validateName = Regex.IsMatch(teacher.Name, $"[A-Z][a-zA-Z]");

            if (validateName)
            {
                Console.WriteLine("Please input your Phone Number");
                teacher.PhoneNumber = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid name");
            }

            

            Console.WriteLine("Please input your Email:");
            teacher.Email = Console.ReadLine();

            Console.WriteLine("Please input your Password:");
            teacher.Password = Console.ReadLine();

            DataStorage.teachers.Add(teacher);
           

        }

        public static void Login(Teacher teacher)
        {
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            if (email == teacher.Email && password == teacher.Password)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login not successful");
            }
        }
    }
}
