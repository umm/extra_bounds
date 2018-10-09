using UnityEngine;

namespace UnityModule.ExtraBounds
{
    public static class RectTransformExtension
    {
        public static float CalcOverlapArea(this RectTransform rectTransform1, RectTransform rectTransform2)
        {
            if (rectTransform1 == default(RectTransform) || rectTransform2 == default(RectTransform))
                return 0;

            return rectTransform1.rect.CalcOverlapArea(rectTransform2.rect);
        } 
    }
}