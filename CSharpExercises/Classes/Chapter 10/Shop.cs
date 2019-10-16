using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_10
{
    public enum SortOrder
    {
        Ascending,
        Descending
    }

    public class Shop
    {
        private List<Film> _films = new List<Film>();
        public List<Film> Films => SortOrder.Equals(SortOrder.Ascending)
            ? _films.OrderBy(f => f.Title).ToList() 
            : _films.OrderByDescending(f => f.Title).ToList();

        public List<Genre> Genres { get; } = new List<Genre>();
        public SortOrder SortOrder { get; }

        public Shop(SortOrder sortOrder)
        {
            SortOrder = sortOrder;

            Genres.AddGenre("Action")
                  .AddGenre("Fantasy")
                  .AddGenre("Adventure")
                  .AddGenre("Crime")
                  .AddGenre("Romance")
                  .AddGenre("Drama")
                  .AddGenre("Horror");

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

                _films.Add(film);

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
        public List<Film> FilterFilms(string filter)
        {
            try
            {
                if (filter == default || filter.Length <= 1) return Films;

                return Films.Where(f =>  f.Title.ToLower().Contains(filter.ToLower())).ToList();

            }
            catch
            {
                return new List<Film>();
            }
        }
        public List<Film> FilterFilms(string filter, int skip, int take)
        {
            IEnumerable<Film> films;

            try
            {
                films = FilterFilms(filter);

                if (skip >= 0) films = films.Skip(skip);
                if (take > 0) films = films.Take(take);
            }
            catch
            {
                films = new List<Film>();
            }

            return films.ToList();
        }
        public List<Film> UnionFilms()
        {
            IEnumerable<Film> films;

            try
            {
                var films1 = Films.Take(2);
                var films2 = Films.Skip(4).Take(1);

                films = films1.Union(films2);
            }
            catch
            {
                films = new List<Film>();
            }

            return films.ToList();
        }
        public List<Genre> GetGenresWithFilms()
        {
            List<Genre> genres = new List<Genre>();

            try
            {
                foreach (var film in Films)
                {
                    var joinedGenres = Genres.Join(
                        film.Genres,
                        genre => genre.Id,
                        filmGenre => filmGenre.Id,
                        (genre, filmGenre) => genre); // new Genre(genre.Id, genre.Name));

                    genres.AddRange(joinedGenres);
                }
            }
            catch
            {
            }

            return genres.Distinct().ToList();
        }

    }
}
