using System.Collections.Generic;
using VividOrange.Geometry;

namespace VividOrange.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static (IPerimeter, IPerimeter) CreateDoubleChannel(IDoubleChannel profile)
        {
            IList<ILocalPoint2d> channelPoints = CreateChannel(profile).OuterEdge.Points;
            return PerimeterFactoryUtility.CreateBackToBackMirror(channelPoints, profile.BackToBackDistance);
        }
    }
}
