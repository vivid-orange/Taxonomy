namespace VividOrange.Profiles
{
    public interface IRectangle : IProfile
    {
        Length Height { get; }
        Length Width { get; }
    }
}
