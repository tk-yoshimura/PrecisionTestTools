using PrecisionTestTools;

namespace PrecisionTestToolsTest {
    [TestClass]
    public class PrecisionCollectionAssertTest {
        [TestMethod]
        public void AreEqualTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5);
            });

            PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-3);

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d], 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d], 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void EqualTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 4d]);
            });

            PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 3d]);

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 4d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d, 4d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AreEqual([1d, 2d, 3d], [1d, 2d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void AlmostEqualTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5);
            });

            PrecisionCollectionAssert.AlmostEqual([100d, 200d, 300d], [100d, 200d, 300d + 1e-4], 1e-5);

            PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-3);

            PrecisionCollectionAssert.AlmostEqual([100d, 200d, 300d], [100d, 200d, 300d + 1e-4], 1e-5, 1e-6);

            PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5, 2e-4);

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5, 1e-6);
            });

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d], 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5, 1e-6);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d], 1e-5, 1e-6);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d], 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d, 3d + 1e-4], 1e-5, 1e-6, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.AlmostEqual([1d, 2d, 3d], [1d, 2d], 1e-5, 1e-6, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNaNTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNaN([1d, 2d, 3d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNaN([1d, 2d, double.NaN]);
            });

            PrecisionCollectionAssert.IsNaN([double.NaN, double.NaN, double.NaN]);

            try {
                PrecisionCollectionAssert.IsNaN([1d, 2d, 3d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsNaN([1d, 2d, 3d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNotNaNTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNotNaN([double.NaN, double.NaN, double.NaN]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNotNaN([1d, 2d, double.NaN]);
            });

            PrecisionCollectionAssert.IsNotNaN([1d, 2d, 3d]);

            try {
                PrecisionCollectionAssert.IsNotNaN([1d, 2d, double.NaN]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsNotNaN([1d, 2d, double.NaN], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsFiniteTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsFinite([double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsFinite([1d, 2d, double.PositiveInfinity]);
            });

            PrecisionCollectionAssert.IsFinite([1d, 2d, 3d]);

            try {
                PrecisionCollectionAssert.IsFinite([1d, 2d, double.PositiveInfinity]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsFinite([1d, 2d, double.PositiveInfinity], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsInfinityTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsInfinity([1d, 2d, 3d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsInfinity([1d, 2d, double.PositiveInfinity]);
            });

            PrecisionCollectionAssert.IsInfinity([double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity]);
            PrecisionCollectionAssert.IsInfinity([double.NegativeInfinity, double.PositiveInfinity, double.PositiveInfinity]);

            try {
                PrecisionCollectionAssert.IsInfinity([1d, 2d, double.PositiveInfinity]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsInfinity([1d, 2d, double.PositiveInfinity], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsPositiveInfinityTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPositiveInfinity([1d, 2d, 3d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPositiveInfinity([1d, 2d, double.PositiveInfinity]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPositiveInfinity([double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPositiveInfinity([double.NegativeInfinity, double.NegativeInfinity, double.PositiveInfinity]);
            });

            PrecisionCollectionAssert.IsPositiveInfinity([double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity]);

            try {
                PrecisionCollectionAssert.IsPositiveInfinity([1d, 2d, double.PositiveInfinity]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsPositiveInfinity([1d, 2d, double.PositiveInfinity], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNegativeInfinityTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNegativeInfinity([1d, 2d, 3d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNegativeInfinity([1d, 2d, double.NegativeInfinity]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNegativeInfinity([double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNegativeInfinity([double.NegativeInfinity, double.NegativeInfinity, double.PositiveInfinity]);
            });

            PrecisionCollectionAssert.IsNegativeInfinity([double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity]);

            try {
                PrecisionCollectionAssert.IsNegativeInfinity([1d, 2d, double.PositiveInfinity]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsNegativeInfinity([1d, 2d, double.PositiveInfinity], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsPositiveTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPositive([-1d, -2d, -3d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPositive([1d, 2d, -3d]);
            });

            PrecisionCollectionAssert.IsPositive([1d, 2d, 3d]);

            try {
                PrecisionCollectionAssert.IsPositive([1d, 2d, -3d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsPositive([1d, 2d, -3d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNegativeTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNegative([1d, 2d, 3d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsNegative([-1d, -2d, 3d]);
            });

            PrecisionCollectionAssert.IsNegative([-1d, -2d, -3d]);

            try {
                PrecisionCollectionAssert.IsNegative([1d, 2d, -3d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsNegative([1d, 2d, -3d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsPlusZeroTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPlusZero([-0d, -0d, -0d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsPlusZero([0d, 0d, -0d]);
            });

            PrecisionCollectionAssert.IsPlusZero([0d, 0d, 0d]);

            try {
                PrecisionCollectionAssert.IsPlusZero([0d, 0d, -0d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsPlusZero([0d, 0d, -0d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsMinusZeroTest() {
            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsMinusZero([0d, 0d, 0d]);
            });

            Assert.ThrowsExactly<AssertFailedException>(() => {
                PrecisionCollectionAssert.IsMinusZero([-0d, -0d, 0d]);
            });

            PrecisionCollectionAssert.IsMinusZero([-0d, -0d, -0d]);

            try {
                PrecisionCollectionAssert.IsMinusZero([0d, 0d, -0d]);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionCollectionAssert.IsMinusZero([0d, 0d, -0d], "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
