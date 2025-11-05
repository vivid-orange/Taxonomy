using System.Collections.Generic;
using VividOrange.Taxonomy.Loads.Cases;

namespace VividOrange.Taxonomy.Loads.Combinations
{
    public interface IAccidentalCombination : IUltimateLimitState
    {
        bool UseFrequentCombinationFactorForMainAccompanying { get; }
        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
