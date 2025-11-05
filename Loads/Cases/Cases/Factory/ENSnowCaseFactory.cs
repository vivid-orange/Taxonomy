using System.Collections.Generic;
using VividOrange.Taxonomy.Loads.Cases.EN;
using VividOrange.Taxonomy.Standards.Eurocode;

namespace VividOrange.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        public static VariableCase CreateSnow(NationalAnnex nationalAnnex, bool altitudeAbove1000m)
        {
            TableA1_1Properties factors = new ENTableA1_1Snow().GetProperties(altitudeAbove1000m, nationalAnnex);
            return new VariableCase()
            {
                CombinationFactor = factors.Phi_0,
                FrequentFactor = factors.Phi_1,
                QuasiPermanentFactor = factors.Phi_2,
                Name = $"Snow loads",
                Nickname = "S",
            };
        }

        public static VariableCase CreateSnow(IList<ILoad> loads, NationalAnnex nationalAnnex, bool altitudeAbove1000m)
        {
            VariableCase loadCase = CreateSnow(nationalAnnex, altitudeAbove1000m);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
