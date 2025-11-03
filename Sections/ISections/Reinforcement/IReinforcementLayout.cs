using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Sections.Reinforcement
{
    public interface IReinforcementLayout : ITaxonomySerializable
    {
        IRebar Rebar { get; }
    }
}
