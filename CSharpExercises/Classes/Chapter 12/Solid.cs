namespace CSharpExercises.Classes.Chapter_12
{
    public class Solid : Matter
    {
        public override States State => GetState(GetType().Name);

        public Solid(string name, double mass) : base (name, mass)
        {
        }

        public override string GetCompression()
        {
            return $"{Name} ({State}): not easily compressible";
        }

        public override string GetShape()
        {
            return $"{Name} ({State}): retains a fixed volume and shape.";
        }

        public override string ParticleMovement()
        {
            return $"{Name} ({State}): rigid - particles cannot move/slide past one another.";
        }

        public override sealed string GetData()
        {
            return $"{Name} {Mass} This is a solid";
        }
    }
}
