using VividOrange.Materials;
using VividOrange.Serialization;

namespace VividOrange.Sections.Reinforcement
{
    public interface IRebar : ITaxonomySerializable
    {
        Length Diameter { get; }
        IMaterial Material { get; }
    }
}
