namespace VividOrange.Materials
{
    public interface ILinearElasticMaterial : IAnalysisMaterial
    {
        Stress ElasticModulus { get; }
        Stress Strength { get; }
        Strain PeakStrain { get; }
    }
}
