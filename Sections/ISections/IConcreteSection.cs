using System.Collections.Generic;
using VividOrange.Sections.Reinforcement;

namespace VividOrange.Sections
{
    public interface IConcreteSection : ISection
    {
        Length Cover { get; }
        IList<ILongitudinalReinforcement> Rebars { get; }
        ILink Link { get; }
    }
}
