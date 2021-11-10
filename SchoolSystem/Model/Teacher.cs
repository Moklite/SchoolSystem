using System.Collections.Generic;

namespace SchoolSystem.Model
{
    public class Teacher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Student> Students { get; set; }
    }
}
