namespace VividOrange.Loads
{
    public interface IPointDisplacement2d : ILoad
    {
        Length X { get; }
        Length Z { get; }
    }
}
