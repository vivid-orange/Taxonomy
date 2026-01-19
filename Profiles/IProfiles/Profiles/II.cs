namespace VividOrange.Profiles
{
    public interface II : IProfile
    {
        Length Height { get; }
        Length Width { get; }
        Length FlangeThickness { get; }
        Length WebThickness { get; }
    }
}
