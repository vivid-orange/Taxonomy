using System.Collections.Generic;
using VividOrange.Taxonomy.Loads.Cases.EN;
using VividOrange.Taxonomy.Standards.Eurocode;

namespace VividOrange.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        public static VariableCase CreateThermal(NationalAnnex nationalAnnex)
        {
            TableA1_1Properties factors = new ENTableA1_1Thermal().GetProperties(nationalAnnex);
            return new VariableCase()
            {
                CombinationFactor = factors.Phi_0,
                FrequentFactor = factors.Phi_1,
                QuasiPermanentFactor = factors.Phi_2,
                Name = $"Thermal loads",
                Nickname = "T",
            };
        }

        public static VariableCase CreateThermal(IList<ILoad> loads, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateThermal(nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
