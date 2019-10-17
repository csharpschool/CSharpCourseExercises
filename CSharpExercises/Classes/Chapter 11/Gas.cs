namespace CSharpExercises.Classes.Chapter_11
{
    public class Gas : IMatter
    {
        public string Name { get; }
        public double Mass { get; }
        public States State => States.Gas;

        public Gas(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        public string GetCompression()
        {
            return $"{Name} ({State}): is compressible.";
        }

        public string GetShape()
        {
            return $"{Name} ({State}): assumes the shape and volume of its container.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): particles can move past one another.";
        }

    }
}
