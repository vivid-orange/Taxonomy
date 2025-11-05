using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Loads
{
    public interface ICase : ITaxonomySerializable
    {
        string Name { get; }
    }
}
