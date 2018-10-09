using UnityEngine;

namespace UnityModule.ExtraBounds
{
    public static class BoundsExtension
    {
        public static float CalcOverlapArea(this Bounds bounds1, Bounds bounds2)
        {
            var minx = bounds1.min.x < bounds2.min.x ? bounds2.min.x : bounds1.min.x;
            var maxx = bounds1.max.x < bounds2.max.x ? bounds1.max.x : bounds2.max.x;
            var miny = bounds1.min.y < bounds2.min.y ? bounds2.min.y : bounds1.min.y;
            var maxy = bounds1.max.y < bounds2.max.y ? bounds1.max.y : bounds2.max.y;

            return minx <= maxx && miny <= maxy
                ? (maxx - minx) * (maxy - miny)
                : 0;
        }
    }
}