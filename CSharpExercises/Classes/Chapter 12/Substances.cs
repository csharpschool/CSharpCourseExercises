using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExercises.Classes.Chapter_12
{
    public class Substances
    {
        List<Matter> Matters { get; } = new List<Matter>();
        public string[] SateNames => Enum.GetNames(typeof(States));
        public States GetSateValue(string name) => (States)Enum.Parse(typeof(States), name);

        public Substances()
        {
            Add(new Solid("Ice", 0.9));
            Add(new Gas("Air", 0.1));
            Add(new Plasma("Lightning", 0.01));
            Add(new Liquid("Water", 1.0));
        }

        public void Add(Matter matter) => Matters.Add(matter);
        public List<Matter> Get() => Matters;
        public List<Matter> Get(Func<Matter, bool> expression) =>
            Matters.Where(expression).ToList();
    }
}
