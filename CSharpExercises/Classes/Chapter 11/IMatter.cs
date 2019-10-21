namespace CSharpExercises.Classes.Chapter_11
{
    public interface IMatter
    {
        string Name { get; }
        double Mass { get; }
        States State { get; }

        string GetShape();
        string GetCompression();
        string ParticleMovement();
    }
}
