using PrecisionTestTools;

namespace PrecisionTestToolsTest {
    [TestClass]
    public class DoubleTest {
        [TestMethod]
        public void AreEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(expected: 1, actual: 1 + 1e-10, abserr: 1e-11);
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

            try {
                PrecisionAssert.AreEqual(2, 2 + (double)1e-10, 1e-11);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AreEqual(2, 2 + (double)1e-10, 1e-11, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void AlmostEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(1, 1 + 1e-10, relerr: 1e-11, abserr: 1e-12);
            });

            PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-9);
            PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-11, 1e-9);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-13);
            });

            PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-9);
            PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-10);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-11);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-11);
            });

            PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-9);
            PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-8);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.NaN, double.NegativeInfinity, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.PositiveInfinity, double.NaN, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.NegativeInfinity, double.NaN, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.PositiveInfinity, double.NegativeInfinity, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.NegativeInfinity, double.PositiveInfinity, 1e-9);
            });

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.NaN, double.NegativeInfinity, 1e-9, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.PositiveInfinity, double.NaN, 1e-9, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.NegativeInfinity, double.NaN, 1e-9, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.PositiveInfinity, double.NegativeInfinity, 1e-9, 1e-9);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(double.NegativeInfinity, double.PositiveInfinity, 1e-9, 1e-9);
            });

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-11, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-11, 1e-12, "message");
            });

            PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-9, "message");
            PrecisionAssert.AlmostEqual(1, 1 + (double)1e-10, 1e-11, 1e-9, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-13, "message");
            });

            PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-9, "message");
            PrecisionAssert.AlmostEqual((double)0.1, (double)0.1 + (double)1e-11, 1e-11, 1e-10, "message");

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-11, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-11, "message");
            });

            PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-9, "message");
            PrecisionAssert.AlmostEqual(10, 10 + (double)1e-9, 1e-11, 1e-8, "message");

            try {
                PrecisionAssert.AlmostEqual(0.1, 0.1 + 1e-10, relerr: 1e-11);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AlmostEqual(0.1, 0.1 + 1e-10, relerr: 1e-11, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AlmostEqual(double.NaN, double.NegativeInfinity, 1e-9);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AlmostEqual(0.1, 0.1 + 1e-10, relerr: 1e-11, abserr: 1e-12);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AlmostEqual(0.1, 0.1 + 1e-10, relerr: 1e-11, abserr: 1e-12, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AlmostEqual(double.NaN, double.NegativeInfinity, 1e-9, 1e-9);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void EqualTest() {
            PrecisionAssert.AreEqual(1d, 1d);
            PrecisionAssert.AreEqual(double.NaN, double.NaN);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(1d, 2d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(1d, double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NaN, 1d);
            });

            PrecisionAssert.AreEqual(1d, 1d, "message");
            PrecisionAssert.AreEqual(double.NaN, double.NaN, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(1d, 2d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(1d, double.NaN, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NaN, 1d, "message");
            });

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NaN, double.NegativeInfinity);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.PositiveInfinity, double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NegativeInfinity, double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.PositiveInfinity, double.NegativeInfinity);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.AreEqual(double.NegativeInfinity, double.PositiveInfinity);
            });

            try {
                PrecisionAssert.AreEqual(1d, 2d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.AreEqual(1d, 2d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNaNTest() {
            PrecisionAssert.IsNaN(double.NaN);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNaN(1d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNaN(double.PositiveInfinity);
            });

            PrecisionAssert.IsNaN(double.NaN, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNaN(1d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNaN(double.PositiveInfinity, "message");
            });

            try {
                PrecisionAssert.IsNaN(1d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsNaN(1d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsFiniteTest() {
            PrecisionAssert.IsFinite(1d);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsFinite(double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsFinite(double.PositiveInfinity);
            });

            PrecisionAssert.IsFinite(1d, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsFinite(double.NaN, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsFinite(double.PositiveInfinity, "message");
            });

            try {
                PrecisionAssert.IsFinite(double.NaN);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsFinite(double.NaN, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsInfinityTest() {
            PrecisionAssert.IsInfinity(double.PositiveInfinity);
            PrecisionAssert.IsInfinity(double.NegativeInfinity);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsInfinity(1d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsInfinity(double.NaN);
            });

            PrecisionAssert.IsInfinity(double.PositiveInfinity, "message");
            PrecisionAssert.IsInfinity(double.NegativeInfinity, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsInfinity(1d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsInfinity(double.NaN, "message");
            });

            try {
                PrecisionAssert.IsInfinity(1d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsInfinity(1d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsPositiveInfinityTest() {
            PrecisionAssert.IsPositiveInfinity(double.PositiveInfinity);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositiveInfinity(1d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositiveInfinity(double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositiveInfinity(double.NegativeInfinity);
            });

            PrecisionAssert.IsPositiveInfinity(double.PositiveInfinity, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositiveInfinity(1d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositiveInfinity(double.NaN, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositiveInfinity(double.NegativeInfinity, "message");
            });

            try {
                PrecisionAssert.IsPositiveInfinity(1d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsPositiveInfinity(1d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNegativeInfinityTest() {
            PrecisionAssert.IsNegativeInfinity(double.NegativeInfinity);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegativeInfinity(1d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegativeInfinity(double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegativeInfinity(double.PositiveInfinity);
            });

            PrecisionAssert.IsNegativeInfinity(double.NegativeInfinity, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegativeInfinity(1d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegativeInfinity(double.NaN, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegativeInfinity(double.PositiveInfinity, "message");
            });

            try {
                PrecisionAssert.IsNegativeInfinity(1d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsNegativeInfinity(1d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsPositiveTest() {
            PrecisionAssert.IsPositive(double.PositiveInfinity);
            PrecisionAssert.IsPositive(1d);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositive(-1d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositive(double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositive(double.NegativeInfinity);
            });

            PrecisionAssert.IsPositive(double.PositiveInfinity, "message");
            PrecisionAssert.IsPositive(1d, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositive(-1d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositive(double.NaN, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPositive(double.NegativeInfinity, "message");
            });

            try {
                PrecisionAssert.IsPositive(-1d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsPositive(-1d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNegativeTest() {
            PrecisionAssert.IsNegative(double.NegativeInfinity);
            PrecisionAssert.IsNegative(-1d);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegative(1d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegative(double.NaN);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegative(double.PositiveInfinity);
            });

            PrecisionAssert.IsNegative(double.NegativeInfinity, "message");
            PrecisionAssert.IsNegative(-1d, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegative(1d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegative(double.NaN, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsNegative(double.PositiveInfinity, "message");
            });

            try {
                PrecisionAssert.IsNegative(1d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsNegative(1d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsPlusZeroTest() {
            PrecisionAssert.IsPlusZero(+0d);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPlusZero(-0d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPlusZero(+1d);
            });

            PrecisionAssert.IsPlusZero(+0d, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPlusZero(-0d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsPlusZero(+1d, "message");
            });

            try {
                PrecisionAssert.IsPlusZero(-0d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsPlusZero(-0d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsMinusZeroTest() {
            PrecisionAssert.IsMinusZero(-0d);
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsMinusZero(+0d);
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsMinusZero(-1d);
            });

            PrecisionAssert.IsMinusZero(-0d, "message");
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsMinusZero(+0d, "message");
            });
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionAssert.IsMinusZero(-1d, "message");
            });

            try {
                PrecisionAssert.IsMinusZero(+0d);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionAssert.IsMinusZero(+0d, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}