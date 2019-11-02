namespace CSharpExercises.Classes.Chapter_12
{
    public class Plasma : Matter
    {
        public override States State => GetState(GetType().Name);

        public Plasma(string name, double mass) : base(name, mass)
        {
        }

        public override string GetCompression() => $"{Name} ({State}): is compressible.";
        public override string GetShape() => $"{Name} ({State}): does not have a shape or volume.";
        public override string ParticleMovement() => $"{Name} ({State}): particles are spread out and move randomly; contain some free ions and electrons, which gives plasma its ability to conduct electricity.";
    }
}
