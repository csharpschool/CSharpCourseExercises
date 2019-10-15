using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_10
{
    public class Shop
    {
        public List<Film> Films { get; } = new List<Film>();
        public List<Genre> Genres { get; } = new List<Genre>();

        public Shop()
        {
            Genres.AddGenre("Action")
                  .AddGenre("Fantasy")
                  .AddGenre("Adventure")
                  .AddGenre("Crime")
                  .AddGenre("Romance")
                  .AddGenre("Drama");

            var action = Genres.First(g => g.Name.Equals("Action"));
            var fantasy = Genres.First(g => g.Name.Equals("Fantasy"));
            var adventure = Genres.First(g => g.Name.Equals("Adventure"));
            var crime = Genres.First(g => g.Name.Equals("Crime"));
            var romance = Genres.First(g => g.Name.Equals("Romance"));
            var drama = Genres.First(g => g.Name.Equals("Drama"));

            AddFilm("The Shawshank Redemption", 1994, drama.Id);
            AddFilm("The Godfather", 1972, drama.Id)
                .AddGenre(crime);
            AddFilm("The Dark Knight", 2008, action.Id)
                .AddGenre(drama).AddGenre(crime);
            AddFilm("Forrest Gump", 1994, romance.Id)
                .AddGenre(drama);
            AddFilm("LOTR: The Return of the King", 2003, fantasy.Id)
                .AddGenre(adventure).AddGenre(drama);
            AddFilm("LOTR: The Two Towers", 2002, fantasy.Id)
                .AddGenre(adventure).AddGenre(drama);
            AddFilm("LOTR: The Fellowship of the Ring", 2001, fantasy.Id)
                .AddGenre(adventure).AddGenre(drama);
        }

        public Film AddFilm(string title, int year, int genreId)
        {
            try
            {
                if (title == default || title.Length.Equals(0))
                    throw new ArgumentException("A film must have a title.");
                if (year < 1800)
                    throw new ArgumentException("Not a valid year.");

                var genre = Genres.SingleOrDefault(g => g.Id.Equals(genreId));

                if (genre == default)
                    throw new ArgumentException("Not a valid genre.");

                var id = Films.Count.Equals(0) ? 1 : Films.Max(m => m.Id) + 1;
                var film = new Film(id, title, year, genre);

                Films.Add(film);

                return Films.Single(f => f.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }


        public int FilmsInGenre(int genreId)
        {
            try
            {
                var genre = Genres.Single(g => g.Id.Equals(genreId));
                var count = Films.Count(f => f.Genres.Contains(genre));
                return count;
            }
            catch
            {
                throw;
            }
        }

    }
}
