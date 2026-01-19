using System.Collections.Generic;
using VividOrange.Loads.Cases;

namespace VividOrange.Loads.Combinations
{
    public interface IServiceabilityLimitState : ILoadCombination
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
