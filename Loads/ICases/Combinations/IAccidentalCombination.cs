using System.Collections.Generic;
using VividOrange.Loads.Cases;

namespace VividOrange.Loads.Combinations
{
    public interface IAccidentalCombination : IUltimateLimitState
    {
        bool UseFrequentCombinationFactorForMainAccompanying { get; }
        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
