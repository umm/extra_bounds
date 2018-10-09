using NUnit.Framework;
using UnityEngine;
using UnityModule.ExtraBounds;

namespace EditTest.UnityModule.ExtraBounds
{
    public class RectExtensionTest : MonoBehaviour
    {
        [Test]
        public void CalcOverlapAreaTest()
        {
            var rect0 = new Rect(Vector2.zero, Vector2.zero);
            var rect1 = new Rect(Vector2.zero, Vector2.one);
            var rect2 = new Rect(Vector2.one * 0.5f, Vector2.one);
            var rect3 = new Rect(Vector2.one, Vector2.one * 3f);

            Assert.AreEqual(0, rect0.CalcOverlapArea(rect0));
            Assert.AreEqual(0, rect0.CalcOverlapArea(rect1));
            Assert.AreEqual(0, rect1.CalcOverlapArea(rect3));
            Assert.AreEqual(1f, rect1.CalcOverlapArea(rect1));
            Assert.AreEqual(0.25f, rect1.CalcOverlapArea(rect2), 1e-6f);
            Assert.AreEqual(0.25f, rect2.CalcOverlapArea(rect3), 1e-6f);
        }
    }
}