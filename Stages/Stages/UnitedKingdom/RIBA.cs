using VividOrange.Taxonomy.Countries;

namespace VividOrange.Taxonomy.Stages.UK
{
    public class RIBA : IGovernance
    {
        public string Name => _name;
        public string FullBodyName => _fullBodyName;
        public ICountry Country => _country;

        private const string _name = "RIBA";
        private const string _fullBodyName = "Royal Institute of British Architects";
        private static readonly ICountry _country = new UnitedKingdom();

        public RIBA() { }
    }
}
