using VividOrange.Standards;

namespace VividOrange.Materials.StandardMaterials
{
    public interface IStandardMaterial : IMaterial
    {
        IStandard Standard { get; }
    }
}
