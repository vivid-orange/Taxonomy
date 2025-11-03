using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Sections.Reinforcement
{
    public interface IMinimumReinforcementSpacing : ITaxonomySerializable
    {
        Ratio BarDiameterFactor { get; set; }
        Length AdditionalAggregateFactor { get; set; }
        Length AbsoluteMinimumSpacing { get; set; }
        Length GetMinimumReinforcementSpacing(Length barDiameter);
    }
}
