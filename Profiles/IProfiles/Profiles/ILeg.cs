namespace VividOrange.Profiles
{
    public interface ILeg : IAngle
    {
        Length FilletRadius { get; }
        Length ToeRadius { get; }
    }
}
