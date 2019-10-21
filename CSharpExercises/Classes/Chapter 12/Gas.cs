using System;

namespace CSharpExercises.Classes.Chapter_12
{
    public class Gas : Matter
    {
        public override States State => GetState(GetType().Name);

        public Gas(string name, double mass) : base(name, mass)
        {
        }

        public override string GetCompression()
        {
            return $"{Name} ({State}): is compressible.";
        }

        public override string GetShape()
        {
            return $"{Name} ({State}): assumes the shape and volume of its container.";
        }

        public override string ParticleMovement()
        {
            return $"{Name} ({State}): particles can move past one another.";
        }

    }
}
