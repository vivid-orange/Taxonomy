using System.Collections.Generic;
using VividOrange.Taxonomy.Loads.Cases;

namespace VividOrange.Taxonomy.Loads.Combinations
{
    public interface ILoadCombination : ICase
    {
        string Definition { get; }
        IList<IPermanentCase> PermanentCases { get; }
        IList<bool> PermanentCaseIsFavourable { get; }
        IList<IVariableCase> LeadingVariableCases { get; }
        IList<ILoad> GetFactoredLoads();
    }
}
