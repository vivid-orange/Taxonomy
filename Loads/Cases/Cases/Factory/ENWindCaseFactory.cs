using System.Collections.Generic;
using VividOrange.Loads.Cases.EN;
using VividOrange.Standards.Eurocode;

namespace VividOrange.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        public static VariableCase CreateWind(NationalAnnex nationalAnnex)
        {
            TableA1_1Properties factors = new ENTableA1_1Wind().GetProperties(nationalAnnex);
            return new VariableCase()
            {
                CombinationFactor = factors.Phi_0,
                FrequentFactor = factors.Phi_1,
                QuasiPermanentFactor = factors.Phi_2,
                Name = $"Wind loads",
                Nickname = "W",
                IsHorizontal = true,
            };
        }

        public static VariableCase CreateWind(IList<ILoad> loads, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateWind(nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
