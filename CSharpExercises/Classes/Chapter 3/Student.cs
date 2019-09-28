using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_3
{
    public class Student
    {
        private readonly string firstName = string.Empty;
        private readonly string lastName = string.Empty;
        public string fullName = string.Empty;
        public readonly int age = default;

        public Student()
        {

        }

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            fullName = $"{firstName} {lastName}";
        }
    }
}