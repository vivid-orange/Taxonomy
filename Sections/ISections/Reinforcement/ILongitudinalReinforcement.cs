namespace VividOrange.Sections.Reinforcement
{
    public interface ILongitudinalReinforcement : IComposite
    {
        IRebar Rebar { get; }
        int CountPerBundle { get; }
    }
}
