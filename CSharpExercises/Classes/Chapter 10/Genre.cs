using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_10
{
    public class Genre
    {
        public int Id { get; }
        public string Name { get; }

        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
