using System.Collections.Generic;
using VividOrange.Loads.Cases;

namespace VividOrange.Loads.Combinations
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
