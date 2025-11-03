using VividOrange.Taxonomy.Materials;
using VividOrange.Taxonomy.Profiles;

namespace VividOrange.Taxonomy.Sections
{
    public class Section : ISection
    {
        public IMaterial Material { get; set; }
        public IProfile Profile { get; set; }

        public Section(IProfile profile, IMaterial material)
        {
            Material = material;
            Profile = profile;
        }
    }
}
