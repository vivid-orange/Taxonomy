using System.Collections.Generic;
using VividOrange.Geometry;

namespace VividOrange.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateCruciform(ICruciform profile)
        {
            return new Perimeter(new List<ILocalPoint2d>()
            {
                new LocalPoint2d(-profile.WebThickness / 2, profile.FlangeThickness / 2),
                new LocalPoint2d(-profile.WebThickness / 2, profile.Height / 2),
                new LocalPoint2d(profile.WebThickness / 2, profile.Height / 2),
                new LocalPoint2d(profile.WebThickness / 2, profile.FlangeThickness / 2),
                new LocalPoint2d(profile.Width / 2, profile.FlangeThickness / 2),
                new LocalPoint2d(profile.Width / 2, -profile.FlangeThickness / 2),
                new LocalPoint2d(profile.WebThickness / 2, -profile.FlangeThickness / 2),
                new LocalPoint2d(profile.WebThickness / 2, -profile.Height / 2),
                new LocalPoint2d(-profile.WebThickness / 2, -profile.Height / 2),
                new LocalPoint2d(-profile.WebThickness / 2, -profile.FlangeThickness / 2),
                new LocalPoint2d(-profile.Width / 2, -profile.FlangeThickness / 2),
                new LocalPoint2d(-profile.Width / 2, profile.FlangeThickness / 2),
                new LocalPoint2d(-profile.WebThickness / 2, profile.FlangeThickness / 2),
            });
        }
    }
}
