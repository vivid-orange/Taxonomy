using VividOrange.Serialization;

namespace VividOrange.Standards
{
    public interface IStandard : ITaxonomySerializable
    {
        StandardBody Body { get; }
        string Title { get; }
    }
}
