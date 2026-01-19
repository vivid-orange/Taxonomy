using System.Collections.Generic;
using VividOrange.Loads.Cases;

namespace VividOrange.Loads.Combinations
{
    public interface IGeotechnicalMemberDesignCombination : IUltimateLimitState
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
