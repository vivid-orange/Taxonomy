using System.Collections.Generic;
using VividOrange.Geometry;

namespace VividOrange.Profiles
{
    public interface IPerimeter : IProfile
    {
        ILocalPolyline2d OuterEdge { get; }
        IList<ILocalPolyline2d> VoidEdges { get; }
    }
}
