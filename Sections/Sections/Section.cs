using VividOrange.Materials;
using VividOrange.Profiles;

namespace VividOrange.Sections
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
