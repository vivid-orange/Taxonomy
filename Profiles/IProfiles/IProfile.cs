using VividOrange.Serialization;

namespace VividOrange.Profiles
{
    public interface IProfile : ITaxonomySerializable
    {
        string Description { get; }
    }
}
