using System.Collections.Generic;
using VividOrange.Geometry;
using VividOrange.Taxonomy.Profiles;
using VividOrange.Taxonomy.Serialization;

namespace VividOrange.Taxonomy.Sections.Reinforcement
{
    public interface IReinforcementLayer : ITaxonomySerializable
    {
        IReinforcementLayout Layout { get; }
        IList<ILongitudinalReinforcement> GetRebars(ILocalPolyline2d path);
        ILocalPolyline2d GetPath(IProfile profile, Length offset);
    }
}
