using VividOrange.Serialization;

namespace VividOrange.Stages
{
    public interface IStage : ITaxonomySerializable
    {
        string Name { get; }
        string Description { get; }
        string Id { get; }
        IGovernance Governance { get; }
    }
}
