
using VividOrange.Taxonomy.Countries;

namespace VividOrange.Taxonomy.Stages
{
    public interface IGovernance
    {
        string Name { get; }
        string FullBodyName { get; }
        ICountry Country { get; }
    }
}
