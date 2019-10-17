namespace CSharpExercises.Classes.Chapter_11
{
    public class Solid : IMatter
    {
        public string Name { get; }
        public double Mass { get; }
        public States State => States.Solid;

        public Solid(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        public string GetCompression()
        {
            return $"{Name} ({State}): not easily compressible";
        }

        public string GetShape()
        {
            return $"{Name} ({State}): retains a fixed volume and shape.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): rigid - particles cannot move/slide past one another.";
        }
    }
}
