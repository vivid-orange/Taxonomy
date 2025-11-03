using System.Collections.Generic;
using VividOrange.Taxonomy.Loads.Cases;

namespace VividOrange.Taxonomy.Loads.Combinations
{
    public interface IGeotechnicalMemberDesignCombination : IUltimateLimitState
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
