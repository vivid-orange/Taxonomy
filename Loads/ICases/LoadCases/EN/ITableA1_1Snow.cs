using VividOrange.Taxonomy.Standards.Eurocode;

namespace VividOrange.Taxonomy.Loads.Cases.EN
{
    public interface ITableA1_1Snow
    {
        TableA1_1Properties GetProperties(bool above1000m, NationalAnnex nationalAnnex);
    }
}
