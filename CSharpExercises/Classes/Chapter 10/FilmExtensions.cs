using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_10
{
    public static class FilmExtensions
    {
        public static Film AddGenre(this Film film, Genre genre)
        {
            if (genre != default) film.Genres.Add(genre);
            return film;
        }

        public static List<Genre> AddGenre(this List<Genre> genres, string name)
        {
            if (name != default && name.Length > 0)
            {
                int id = genres.Count.Equals(0) ? 1 : genres.Max(m => m.Id) + 1;
                var genre = new Genre(id, name);
                genres.Add(genre);
            }

            return genres;
        }


    }
}
