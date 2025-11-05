using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Materials
{
    public interface IMaterial : ITaxonomySerializable
    {
        MaterialType Type { get; }
    }
}
