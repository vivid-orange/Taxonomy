using VividOrange.Standards.Eurocode;

namespace VividOrange.Loads.Combinations.EN
{
    public interface ITableA1_2
    {
        TableA1_2Properties GetProperties(NationalAnnex nationalAnnex);
    }
}
