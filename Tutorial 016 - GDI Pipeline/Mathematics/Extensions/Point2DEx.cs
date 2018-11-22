﻿using System.Runtime.CompilerServices;
using MathNet.Spatial.Euclidean;

namespace RCi.Tutorials.Gfx.Mathematics.Extensions
{
    public static class Point2DEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point2D ToPoint2D(this System.Drawing.Point point) => new Point2D(point.X, point.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point2D ToPoint2D(this System.Windows.Point point) => new Point2D(point.X, point.Y);
    }
}
