namespace CSharpExercises.Classes.Chapter_11
{
    public enum States
    {
        Liquid,
        Gas,
        Solid,
        Plasma
    }

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
