using VividOrange.Materials;
using VividOrange.Profiles;
using VividOrange.Serialization;

namespace VividOrange.Sections
{
    public interface ISection : ITaxonomySerializable
    {
        IMaterial Material { get; }
        IProfile Profile { get; }
    }
}
