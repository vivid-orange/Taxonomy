using VividOrange.Serialization;

namespace VividOrange.Loads
{
    public interface ILoad : ITaxonomySerializable
    {
        string Label { get; }
        ILoad Factor(Ratio factor);
    }
}
