using CSharpExercises.Classes.Chapter_10;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpExercises.Tests.Chapter_10
{
    public class FilmTests
    {
        [Fact]
        public void CanCreateInstanceWithGenre()
        {
            var genre = new Genre(1, "Action");
            var film = new Film(1, "The Title", 1920, genre);

            Assert.NotNull(film);
            Assert.Equal(1, film.Id);
            Assert.Equal(1920, film.Year);
            Assert.Equal("The Title", film.Title);
            Assert.NotEmpty(film.Genres);
        }

        [Fact]
        public void CanCreateInstanceWithoutGenre()
        {
            var film = new Film(1, "The Title", 1920);

            Assert.NotNull(film);
            Assert.Equal(1, film.Id);
            Assert.Equal(1920, film.Year);
            Assert.Equal("The Title", film.Title);
            Assert.Empty(film.Genres);
        }

    }
}
