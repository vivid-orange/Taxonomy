namespace VividOrange.Taxonomy.Sections.Reinforcement
{
    public interface ILongitudinalReinforcement : IComposite
    {
        IRebar Rebar { get; }
        int CountPerBundle { get; }
    }
}
