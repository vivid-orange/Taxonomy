namespace VividOrange.Profiles
{
    public interface IRoundedRectangle : IRectangle
    {
        Length FlatHeight { get; }
        Length FlatWidth { get; }
    }
}
