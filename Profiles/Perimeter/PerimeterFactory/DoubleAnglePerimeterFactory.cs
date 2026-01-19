using System.Collections.Generic;
using VividOrange.Geometry;

namespace VividOrange.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static (IPerimeter, IPerimeter) CreateDoubleAngle(IDoubleAngle profile)
        {
            IList<ILocalPoint2d> anglePoints = CreateAngle(profile).OuterEdge.Points;
            return PerimeterFactoryUtility.CreateBackToBackMirror(anglePoints, profile.BackToBackDistance);
        }
    }
}
