using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Profiles
{
    public interface IProfile : ITaxonomySerializable
    {
        string Description { get; }
    }
}
