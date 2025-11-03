using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Standards
{
    public interface IStandard : ITaxonomySerializable
    {
        StandardBody Body { get; }
        string Title { get; }
    }
}
