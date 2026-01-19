// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using VividOrange.Geometry;
using VividOrange.Serialization;

namespace VividOrange.Sections
{
    public interface IComposite : ITaxonomySerializable
    {
        ILocalPoint2d Position { get; }
    }
}
