using Xunit;
using CSharpExercises.Classes.Chapter_10;
using System;

namespace CSharpExercises.Tests.Chapter_10
{
    public class GenreTests
    {
        [Fact]
        public void CanCreateGenreInstance()
        {
            var genre = new Genre(1, "Action");

            Assert.NotNull(genre);
            Assert.Equal(1, genre.Id);
            Assert.Equal("Action", genre.Name);
        }
    }
}

