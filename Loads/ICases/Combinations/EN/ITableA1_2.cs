using VividOrange.Taxonomy.Standards.Eurocode;

namespace VividOrange.Taxonomy.Loads.Combinations.EN
{
    public interface ITableA1_2
    {
        TableA1_2Properties GetProperties(NationalAnnex nationalAnnex);
    }
}
