using VividOrange.Taxonomy.Materials;
using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Sections.Reinforcement
{
    public interface IRebar : ITaxonomySerializable
    {
        Length Diameter { get; }
        IMaterial Material { get; }
    }
}
