namespace VividOrange.Profiles
{
    public interface IITaperFlange : II
    {
        Length FilletRadius { get; }
        Length ToeRadius { get; }
        Length WebHeight { get; }
    }
}
