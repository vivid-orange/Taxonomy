using VividOrange.Geometry;
using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Sections
{
    public interface IComposite : ITaxonomySerializable
    {
        ILocalPoint2d Position { get; }
    }
}
