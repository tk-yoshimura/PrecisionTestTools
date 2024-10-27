using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace PrecisionTestTools {
    public static class PrecisionAssert {
        public static void AreEqual<T>(T expected, T actual, T delta) where T : INumber<T> {
            AreEqual(expected, actual, delta, string.Empty);
        }

        public static void AreEqual<T>(T expected, T actual, T delta, string message) where T : INumber<T> {
            if (T.IsInfinity(expected)) {
                Assert.IsTrue(T.IsInfinity(actual), $"{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}\n{message}");
                Assert.AreEqual(T.Sign(expected), T.Sign(actual), $"{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}\n{message}");
                return;
            }

            Assert.AreEqual(T.IsNaN(expected), T.IsNaN(actual), $"{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}\n{message}");

            if (T.Abs(expected - actual) > delta) {
                throw new AssertFailedException($"{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}\n{message}");
            }
        }

        public static void MlmostEqual<T>(T expected, T actual, T relerr) where T : INumber<T> {
            T delta = T.Abs(expected) * relerr;

            AreEqual(expected, actual, delta);
        }

        public static void MlmostEqual<T>(T expected, T actual, T relerr, string message) where T : INumber<T> {
            T delta = T.Abs(expected) * relerr;

            AreEqual(expected, actual, delta, message);
        }

        public static void MlmostEqual<T>(T expected, T actual, T relerr, T abserr) where T : INumber<T> {
            T delta = T.Abs(expected) * relerr + abserr;

            AreEqual(expected, actual, delta);
        }

        public static void MlmostEqual<T>(T expected, T actual, T relerr, T abserr, string message) where T : INumber<T> {
            T delta = T.Abs(expected) * relerr + abserr;

            AreEqual(expected, actual, delta, message);
        }
    }
}
