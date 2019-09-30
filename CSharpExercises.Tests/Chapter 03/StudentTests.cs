using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CSharpExercises.Classes.Chapter_03;

namespace CSharpExercises.Tests.Chapter_03
{
    public class StudentTests
    {
        [Fact]
        public void CanCreateStudentDefaultInstance()
        {
            var student = new Student();

            Assert.NotNull(student);
        }

        [Fact]
        public void CanCreateStudentInstanceWithParameters()
        {
            var student = new Student("John", "Doe", 23);

            Assert.NotNull(student);
            Assert.Equal(23, student.age);
            Assert.Equal("John Doe", student.fullName);
        }
    }
}
