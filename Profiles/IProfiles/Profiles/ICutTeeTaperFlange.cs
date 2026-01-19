namespace VividOrange.Profiles
{
    public interface ICutTeeTaperFlange : ITee
    {
        Length FilletRadius { get; }
        Length ToeRadius { get; }
    }
}
