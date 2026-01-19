namespace VividOrange.Loads
{
    public interface IPointForce2d : ILoad
    {
        Force X { get; }
        Force Z { get; }
    }
}
