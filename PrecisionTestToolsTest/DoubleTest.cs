using DoubleDouble;
using PrecisionTestTools;

namespace PrecisionTestToolsTest {
    [TestClass]
    public class DoubleTest {
        [TestMethod]
        public void AreEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(expected: 1, actual: 1 + 1e-10, delta: 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(2, 2 + (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.Pi, double.Pi + (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-double.Pi, -double.Pi + (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(1, 1 - (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(2, 2 - (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.Pi, double.Pi - (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-double.Pi, -double.Pi - (double)1e-10, 1e-11);
            });
            PrecisionAssert.AreEqual(2, 2 + (double)1e-10, 1e-9);
            PrecisionAssert.AreEqual(-(double)2, -(double)2 + (double)1e-10, 1e-9);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-(double)2, 2 + (double)1e-10, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(2, -(double)2 + (double)1e-10, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NaN, 2 + (double)1e-10, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(2 + (double)1e-10, double.NaN, 1e-9);
            });
            PrecisionAssert.AreEqual(double.NaN, double.NaN, 1e-9);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NaN, double.PositiveInfinity, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NaN, double.NegativeInfinity, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.PositiveInfinity, double.NaN, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NegativeInfinity, double.NaN, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.PositiveInfinity, double.NegativeInfinity, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NegativeInfinity, double.PositiveInfinity, 1e-9);
            });
            PrecisionAssert.AreEqual(double.PositiveInfinity, double.PositiveInfinity, 1e-9);
            PrecisionAssert.AreEqual(double.NegativeInfinity, double.NegativeInfinity, 1e-9);
        }

        [TestMethod]
        public void MlmostEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(1, 1 + 1e-10, relerr: 1e-11, abserr: 1e-12);
            });

            PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-9);
            PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-11, 1e-9);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-13);
            });

            PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-9);
            PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-10);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-11);
            });

            PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-9);
            PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-8);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-11, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-11, 1e-12, "message");
            });

            PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-9, "message");
            PrecisionAssert.MlmostEqual(1, 1 + (double)1e-10, 1e-11, 1e-9, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-13, "message");
            });

            PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-9, "message");
            PrecisionAssert.MlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-10, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-11, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-11, "message");
            });

            PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-9, "message");
            PrecisionAssert.MlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-8, "message");
        }
    }
}