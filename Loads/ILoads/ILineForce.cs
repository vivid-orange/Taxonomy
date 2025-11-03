namespace VividOrange.Taxonomy.Loads
{
    public interface ILineForce : ILineForce2d
    {
        ForcePerLength Y { get; }
    }
}
