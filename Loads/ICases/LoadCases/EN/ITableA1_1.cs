using VividOrange.Standards.Eurocode;

namespace VividOrange.Loads.Cases.EN
{
    public interface ITableA1_1
    {
        TableA1_1Properties GetProperties(NationalAnnex nationalAnnex);
    }
}
