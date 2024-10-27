using MultiPrecision;
using PrecisionTestTools;

namespace PrecisionTestToolsTest {
    [TestClass]
    public class MPTest {
        [TestMethod]
        public void AreEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)2, (MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.PI, MultiPrecision<Pow2.N4>.PI + (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-MultiPrecision<Pow2.N4>.PI, -MultiPrecision<Pow2.N4>.PI + (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 - (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)2, (MultiPrecision<Pow2.N4>)2 - (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.PI, MultiPrecision<Pow2.N4>.PI - (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-MultiPrecision<Pow2.N4>.PI, -MultiPrecision<Pow2.N4>.PI - (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)2, (MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27);
            PrecisionAssert.AreEqual(-(MultiPrecision<Pow2.N4>)2, -(MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-(MultiPrecision<Pow2.N4>)2, (MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)2, -(MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NaN, (MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((MultiPrecision<Pow2.N4>)2 + (MultiPrecision<Pow2.N4>)1e-28, MultiPrecision<Pow2.N4>.NaN, 1e-27);
            });
            PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NaN, MultiPrecision<Pow2.N4>.NaN, 1e-27);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NaN, MultiPrecision<Pow2.N4>.PositiveInfinity, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NaN, MultiPrecision<Pow2.N4>.NegativeInfinity, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.PositiveInfinity, MultiPrecision<Pow2.N4>.NaN, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NegativeInfinity, MultiPrecision<Pow2.N4>.NaN, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.PositiveInfinity, MultiPrecision<Pow2.N4>.NegativeInfinity, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NegativeInfinity, MultiPrecision<Pow2.N4>.PositiveInfinity, 1e-27);
            });
            PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.PositiveInfinity, MultiPrecision<Pow2.N4>.PositiveInfinity, 1e-27);
            PrecisionAssert.AreEqual(MultiPrecision<Pow2.N4>.NegativeInfinity, MultiPrecision<Pow2.N4>.NegativeInfinity, 1e-27);
        }

        [TestMethod]
        public void MlmostEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29, 1e-40);
            });

            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27);
            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29, 1e-27);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-29, 1e-41);
            });

            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-27);
            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-29, 1e-28);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-29, 1e-39);
            });

            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-27);
            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-29, 1e-26);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29, 1e-40, "message");
            });

            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-27, "message");
            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)1, (MultiPrecision<Pow2.N4>)1 + (MultiPrecision<Pow2.N4>)1e-28, 1e-29, 1e-27, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-29, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-29, 1e-41, "message");
            });

            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-27, "message");
            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)0.1, (MultiPrecision<Pow2.N4>)0.1 + (MultiPrecision<Pow2.N4>)1e-29, 1e-29, 1e-28, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-29, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-29, 1e-39, "message");
            });

            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-27, "message");
            PrecisionAssert.MlmostEqual((MultiPrecision<Pow2.N4>)10, (MultiPrecision<Pow2.N4>)10 + (MultiPrecision<Pow2.N4>)1e-27, 1e-29, 1e-26, "message");
        }
    }
}