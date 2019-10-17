namespace CSharpExercises.Classes.Chapter_11
{
    public class Plasma : IMatter
    {
        public string Name { get; }
        public double Mass { get; }
        public States State => States.Plasma;

        public Plasma(string name, double mass)
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
            return $"{Name} ({State}): does not have a shape or volume.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): particles are spread out and move randomly; contain some free ions and electrons, which gives plasma its ability to conduct electricity.";
        }
    }
}
