using SchoolSystem.Model;

namespace SchoolSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            Result result = new Result();
           
            
            Authentication.Register(teacher);
            Authentication.Login(teacher);
            RegisterStudent.RegisterStudentDetails(student);
            DisplayResult.DisplayStudentResult(result);

        }
    }
}
