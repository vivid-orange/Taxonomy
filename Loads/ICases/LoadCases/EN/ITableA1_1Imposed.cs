using VividOrange.Standards.Eurocode;

namespace VividOrange.Loads.Cases.EN
{
    public interface ITableA1_1Imposed
    {
        TableA1_1Properties GetProperties(ImposedLoadCategory category, NationalAnnex nationalAnnex);
    }
}
