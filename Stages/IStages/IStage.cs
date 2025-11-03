using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Stages
{
    public interface IStage : ITaxonomySerializable
    {
        string Name { get; }
        string Description { get; }
        string Id { get; }
        IGovernance Governance { get; }
    }
}
