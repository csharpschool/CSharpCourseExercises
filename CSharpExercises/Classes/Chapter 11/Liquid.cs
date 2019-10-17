namespace CSharpExercises.Classes.Chapter_11
{
    public class Liquid : IMatter
    {
        public string Name { get; }
        public double Mass { get; }
        public States State => States.Liquid;

        public Liquid(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        public string GetCompression()
        {
            return $"{Name} ({State}): does not compress easily.";
        }

        public string GetShape()
        {
            return $"{Name} ({State}): assumes the shape of the part of the container which it occupies.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): particles can move/slide past one another.";
        }
    }
}
