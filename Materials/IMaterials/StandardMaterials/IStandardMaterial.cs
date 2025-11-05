using VividOrange.Taxonomy.Standards;

namespace VividOrange.Taxonomy.Materials.StandardMaterials
{
    public interface IStandardMaterial : IMaterial
    {
        IStandard Standard { get; }
    }
}
