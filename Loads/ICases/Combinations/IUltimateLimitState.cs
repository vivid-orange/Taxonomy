namespace VividOrange.Loads.Combinations
{
    public interface IUltimateLimitState : ILoadCombination
    {
        IDesignSituation DesignSituation { get; }
    }
}
