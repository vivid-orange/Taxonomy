using VividOrange.Serialization;

namespace VividOrange.Materials
{
    public interface IMaterial : ITaxonomySerializable
    {
        MaterialType Type { get; }
    }
}
