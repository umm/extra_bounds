using UnityEngine;

namespace UnityModule.ExtraBounds
{
    public static class RectExtension
    {
        public static float CalcOverlapArea(this Rect rect1, Rect rect2)
        {
            var minx = rect1.min.x < rect2.min.x ? rect2.min.x : rect1.min.x;
            var maxx = rect1.max.x < rect2.max.x ? rect1.max.x : rect2.max.x;
            var miny = rect1.min.y < rect2.min.y ? rect2.min.y : rect1.min.y;
            var maxy = rect1.max.y < rect2.max.y ? rect1.max.y : rect2.max.y;

            return minx <= maxx && miny <= maxy
                ? (maxx - minx) * (maxy - miny)
                : 0;
        }
    }
}