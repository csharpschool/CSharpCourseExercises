using System;

namespace CSharpExercises.Classes.Chapter_12
{
    public abstract class Matter
    {
        public string Name { get; }
        public double Mass { get; }
        public abstract States State { get; }

        protected Matter(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        protected States GetState(string name)
        { 
            return (States)Enum.Parse(typeof(States), name);
        }
        public abstract string GetShape();
        public abstract string GetCompression();
        public abstract string ParticleMovement();

        public virtual string GetData()
        {
            return $"{Name} {Mass} {State}";
        }
    }
}
