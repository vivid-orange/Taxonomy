using System.Collections.Generic;
using VividOrange.Taxonomy.Sections.Reinforcement;

namespace VividOrange.Taxonomy.Sections
{
    public interface IConcreteSection : ISection
    {
        Length Cover { get; }
        IList<ILongitudinalReinforcement> Rebars { get; }
        ILink Link { get; }
    }
}
