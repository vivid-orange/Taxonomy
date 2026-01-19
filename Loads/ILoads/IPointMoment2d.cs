namespace VividOrange.Loads
{
    public interface IPointMoment2d : ILoad
    {
        Moment Yy { get; }
        Moment Zz { get; }
    }
}
