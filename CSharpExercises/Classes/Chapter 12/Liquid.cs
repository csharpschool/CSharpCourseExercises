namespace CSharpExercises.Classes.Chapter_12
{
    public class Liquid : Matter
    {
        public override States State => GetState(GetType().Name);

        public Liquid(string name, double mass) : base(name, mass)
        {
        }

        public override string GetCompression()
        {
            return $"{Name} ({State}): does not compress easily.";
        }

        public override string GetShape()
        {
            return $"{Name} ({State}): assumes the shape of the part of the container which it occupies.";
        }

        public override string ParticleMovement()
        {
            return $"{Name} ({State}): particles can move/slide past one another.";
        }
    }
}
