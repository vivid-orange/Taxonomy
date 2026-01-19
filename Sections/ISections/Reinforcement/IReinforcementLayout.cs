using VividOrange.Serialization;

namespace VividOrange.Sections.Reinforcement
{
    public interface IReinforcementLayout : ITaxonomySerializable
    {
        IRebar Rebar { get; }
    }
}
