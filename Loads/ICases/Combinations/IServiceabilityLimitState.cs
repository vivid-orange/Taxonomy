using System.Collections.Generic;
using VividOrange.Taxonomy.Loads.Cases;

namespace VividOrange.Taxonomy.Loads.Combinations
{
    public interface IServiceabilityLimitState : ILoadCombination
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
