using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_10
{
    public class Film
    {
        public int Id { get; }
        public string Title { get; }
        public int Year { get; }
        public List<Genre> Genres { get; } = new List<Genre>();
        public string Info { 
            get {
                var genres = string.Empty;

                foreach (var genre in Genres)
                    genres += $"{genre.Name} ";

                return $"{Title} ({Year}) [{genres}]";
            } 
        }

        public Film(int id, string title, int year, Genre genre = default)
        {
            Id = id;
            Title = title;
            Year = year;
            this.AddGenre(genre);
        }
    }
}
