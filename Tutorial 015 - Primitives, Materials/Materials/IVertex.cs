﻿using MathNet.Spatial.Euclidean;

namespace RCi.Tutorials.Gfx.Materials
{
    /// <summary>
    /// Defines raw vertex.
    /// </summary>
    public interface IVertex
    {
    }

    /// <summary>
    /// Defines <see cref="IVertex"/> which has <see cref="Position"/>.
    /// </summary>
    public interface IVertexPosition :
        IVertex
    {
        Point3D Position { get; }
    }
}
