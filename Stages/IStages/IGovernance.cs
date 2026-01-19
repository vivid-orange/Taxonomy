
using VividOrange.Countries;

namespace VividOrange.Stages
{
    public interface IGovernance
    {
        string Name { get; }
        string FullBodyName { get; }
        ICountry Country { get; }
    }
}
