using VividOrange.Serialization;

namespace VividOrange.Loads
{
    public interface ICase : ITaxonomySerializable
    {
        string Name { get; }
    }
}
