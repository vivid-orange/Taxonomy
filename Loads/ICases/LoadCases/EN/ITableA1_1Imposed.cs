using VividOrange.Taxonomy.Standards.Eurocode;

namespace VividOrange.Taxonomy.Loads.Cases.EN
{
    public interface ITableA1_1Imposed
    {
        TableA1_1Properties GetProperties(ImposedLoadCategory category, NationalAnnex nationalAnnex);
    }
}
