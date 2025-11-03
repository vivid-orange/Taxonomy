namespace VividOrange.Taxonomy.Profiles
{
    public interface IRoundedRectangle : IRectangle
    {
        Length FlatHeight { get; }
        Length FlatWidth { get; }
    }
}
