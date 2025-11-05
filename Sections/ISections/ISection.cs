using VividOrange.Taxonomy.Materials;
using VividOrange.Taxonomy.Profiles;
using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Sections
{
    public interface ISection : ITaxonomySerializable
    {
        IMaterial Material { get; }
        IProfile Profile { get; }
    }
}
