using System;

namespace VividOrange.Taxonomy.Standards.Eurocode
{
    public class MissingNationalAnnexException : Exception
    {
        public MissingNationalAnnexException(NationalAnnex na) : base($"National Annex of {na} not implemented") { }
    }
}
