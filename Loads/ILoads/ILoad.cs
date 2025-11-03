using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Loads
{
    public interface ILoad : ITaxonomySerializable
    {
        string Label { get; }
        ILoad Factor(Ratio factor);
    }
}
