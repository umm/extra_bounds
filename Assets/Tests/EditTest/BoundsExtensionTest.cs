using NUnit.Framework;
using UnityEngine;
using UnityModule.ExtraBounds;

namespace EditTest.UnityModule.ExtraBounds
{
    public class BoundsExtensionTest
    {
        [Test]
        public void CalcOverlapAreaTest()
        {
            var bounds0 = new Bounds(Vector3.zero, Vector3.zero);
            var bounds1 = new Bounds(Vector3.one * 0.5f, Vector3.one);
            var bounds2 = new Bounds(Vector3.one, Vector3.one);
            var bounds3 = new Bounds(Vector3.one * 2.5f, Vector3.one * 3f);

            Assert.AreEqual(0, bounds0.CalcOverlapArea(bounds0));
            Assert.AreEqual(0, bounds0.CalcOverlapArea(bounds1));
            Assert.AreEqual(0, bounds1.CalcOverlapArea(bounds3));
            Assert.AreEqual(1f, bounds1.CalcOverlapArea(bounds1));
            Assert.AreEqual(0.25f, bounds1.CalcOverlapArea(bounds2), 1e-6f);
            Assert.AreEqual(0.25f, bounds2.CalcOverlapArea(bounds3), 1e-6f);
        }
    }
}