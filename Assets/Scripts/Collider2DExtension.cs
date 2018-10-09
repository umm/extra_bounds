using UnityEngine;

namespace UnityModule.ExtraBounds
{
    public static class Collider2DExtension
    {
        public static float CalcOverlapArea(this Collider2D collider1, Collider2D collider2)
        {
            if (collider1 == default(Collider2D) || collider2 == default(Collider2D))
                return 0;

            return collider1.bounds.CalcOverlapArea(collider2.bounds);
        }
    }
}