using DoubleDouble;
using PrecisionTestTools;

namespace PrecisionTestToolsTest {
    [TestClass]
    public class DDoubleTest {
        [TestMethod]
        public void AreEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((ddouble)2, (ddouble)2 + (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.PI, ddouble.PI + (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-ddouble.PI, -ddouble.PI + (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((ddouble)1, (ddouble)1 - (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((ddouble)2, (ddouble)2 - (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.PI, ddouble.PI - (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-ddouble.PI, -ddouble.PI - (ddouble)1e-28, 1e-29);
            });
            PrecisionAssert.AreEqual((ddouble)2, (ddouble)2 + (ddouble)1e-28, 1e-27);
            PrecisionAssert.AreEqual(-(ddouble)2, -(ddouble)2 + (ddouble)1e-28, 1e-27);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(-(ddouble)2, (ddouble)2 + (ddouble)1e-28, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((ddouble)2, -(ddouble)2 + (ddouble)1e-28, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.NaN, (ddouble)2 + (ddouble)1e-28, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual((ddouble)2 + (ddouble)1e-28, ddouble.NaN, 1e-27);
            });
            PrecisionAssert.AreEqual(ddouble.NaN, ddouble.NaN, 1e-27);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.NaN, ddouble.PositiveInfinity, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.NaN, ddouble.NegativeInfinity, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.PositiveInfinity, ddouble.NaN, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.NegativeInfinity, ddouble.NaN, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.PositiveInfinity, ddouble.NegativeInfinity, 1e-27);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(ddouble.NegativeInfinity, ddouble.PositiveInfinity, 1e-27);
            });
            PrecisionAssert.AreEqual(ddouble.PositiveInfinity, ddouble.PositiveInfinity, 1e-27);
            PrecisionAssert.AreEqual(ddouble.NegativeInfinity, ddouble.NegativeInfinity, 1e-27);
        }

        [TestMethod]
        public void AlmostEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29, 1e-40);
            });

            PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-27);
            PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29, 1e-27);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-29, 1e-41);
            });

            PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-27);
            PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-29, 1e-28);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-29);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-29, 1e-39);
            });

            PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-27);
            PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-29, 1e-26);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29, 1e-40, "message");
            });

            PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-27, "message");
            PrecisionAssert.AlmostEqual((ddouble)1, (ddouble)1 + (ddouble)1e-28, 1e-29, 1e-27, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-29, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-29, 1e-41, "message");
            });

            PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-27, "message");
            PrecisionAssert.AlmostEqual((ddouble)0.1, (ddouble)0.1 + (ddouble)1e-29, 1e-29, 1e-28, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-29, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-29, 1e-39, "message");
            });

            PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-27, "message");
            PrecisionAssert.AlmostEqual((ddouble)10, (ddouble)10 + (ddouble)1e-27, 1e-29, 1e-26, "message");
        }
    }
}