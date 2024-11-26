using PrecisionTestTools;

namespace PrecisionTestToolsTest {
    [TestClass]
    public class PrecisionVectorAssertTest {
        [TestMethod]
        public void AreEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4));
            });

            PrecisionVectorAssert.AreEqual((2, 0), (2, 0));

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4), 1e-5);
            });

            PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4), 1e-3);

            try {
                PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4), 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4), 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4), 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionVectorAssert.AreEqual((2, 0), (2, 1e-4), 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void AlmostEqualTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5);
            });

            PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-3);

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5, 1e-5);
            });

            PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5, 1e-3);

            try {
                PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5);
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }

            try {
                PrecisionVectorAssert.AlmostEqual((2, 0), (2, 1e-4), 1e-5, "message");
            }
            catch (AssertFailedException e) {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsFiniteTest() {
            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionVectorAssert.IsFinite((2, double.PositiveInfinity));
            });

            Assert.ThrowsException<AssertFailedException>(() => {
                PrecisionVectorAssert.IsFinite((double.PositiveInfinity, 2));
            });

            PrecisionVectorAssert.IsFinite((1d, 2d));
        }
    }
}
