using ConsoleTables;
using SchoolSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public static class DisplayResult
    {
        public static void DisplayStudentResult(Result result)
        {
        Start:
            Console.WriteLine("To enter result press 1, To display result press 2: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Enter the student name: ");
                result.StudentName = Console.ReadLine();

                Console.WriteLine("Enter the student class: ");
                result.Class = Console.ReadLine();

                Console.WriteLine("Enter the subject: ");
                result.Subject = Console.ReadLine();

                Console.WriteLine("Enter the CA: ");
                result.Ca = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the exam score: ");
                result.Exam = int.Parse(Console.ReadLine());

                result.Average = result.Ca + result.Exam;

                if(result.Average >= 80 && result.Average <= 100)
                {
                    result.Remark = "Very good";
                }
                else if(result.Average >= 60 && result.Average <= 79)
                {
                    result.Remark = "good";
                }
                else if(result.Average >= 0 && result.Average <= 59)
                {
                    result.Remark = "poor";
                }

                DataStorage.results.Add(result);
                goto Start;
            }

            else if (input == "2")
            {
                Console.WriteLine("Student Name: " + result.StudentName);
                //ConsoleTable.From<Result>.Write();
            }
            

        }
    }
}
