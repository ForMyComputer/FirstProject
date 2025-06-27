using System;

namespace Problem
{
    class Program
    {
        static void Main()
        {
            Student user1 = new Student()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Stephan",
                Age = 24,
                Now = DateTime.UtcNow
            };

            Student user2 = new Student()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Stephan",
                Age = 24,
                Now = DateTime.UtcNow
            };

            Student user3 = new Student()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Stephan",
                Age = 24,
                Now = DateTime.UtcNow
            };




        }
    }
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Now { get; set; }
    }
}