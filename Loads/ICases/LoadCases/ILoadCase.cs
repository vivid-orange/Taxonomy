using System.Collections.Generic;

namespace VividOrange.Taxonomy.Loads.Cases
{
    public interface ILoadCase : ICase
    {
        string Nickname { get; }
        IList<ILoad> Loads { get; }
        bool IsHorizontal { get; }
        ActionClass ActionClass { get; }
    }
}
