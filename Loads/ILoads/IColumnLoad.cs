namespace VividOrange.Taxonomy.Loads
{
    public interface IColumnLoad : ILoad
    {
        Force Force { get; }
        IPointMoment2d TopMoment { get; }
        IPointMoment2d BottomMoment { get; }
    }
}
