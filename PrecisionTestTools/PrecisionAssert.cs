using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace PrecisionTestTools {
    public static class PrecisionAssert {
        public static void AreEqual<T>(T expected, T actual) where T : INumber<T> {
            AreEqual(expected, actual, string.Empty);
        }

        public static void AreEqual<T>(T expected, T actual, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsInfinity(expected)) {
                Assert.IsTrue(T.IsInfinity(actual), $"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
                Assert.AreEqual(T.Sign(expected), T.Sign(actual), $"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
                return;
            }

            if (T.IsNaN(expected)) {
                Assert.IsTrue(T.IsNaN(actual), $"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
            }
            else if (expected != actual) {
                throw new AssertFailedException($"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
            }
        }

        public static void AreEqual<T>(T expected, T actual, T delta) where T : INumber<T> {
            AreEqual(expected, actual, delta, string.Empty);
        }

        public static void AreEqual<T>(T expected, T actual, T delta, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsInfinity(expected)) {
                Assert.IsTrue(T.IsInfinity(actual), $"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
                Assert.AreEqual(T.Sign(expected), T.Sign(actual), $"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
                return;
            }

            Assert.AreEqual(T.IsNaN(expected), T.IsNaN(actual), $"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");

            if (T.Abs(expected - actual) > delta) {
                throw new AssertFailedException($"{message}{nameof(expected)}:{expected}\n{nameof(actual)}:  {actual}");
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

        public static void IsNaN<T>(T value) where T : INumber<T> {
            IsNaN(value, string.Empty);
        }

        public static void IsNaN<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsNaN(value), $"{message}expected:NaN\n{nameof(value)}:   {value}");
        }

        public static void IsFinite<T>(T value) where T : INumber<T> {
            IsFinite(value, string.Empty);
        }

        public static void IsFinite<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsFinite(value), $"{message}expected:finite\n{nameof(value)}:   {value}");
        }

        public static void IsInfinity<T>(T value) where T : INumber<T> {
            IsInfinity(value, string.Empty);
        }

        public static void IsInfinity<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsInfinity(value), $"{message}expected:infinity\n{nameof(value)}:   {value}");
        }

        public static void IsPositiveInfinity<T>(T value) where T : INumber<T> {
            IsPositiveInfinity(value, string.Empty);
        }

        public static void IsPositiveInfinity<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsPositiveInfinity(value), $"{message}expected:+infinity\n{nameof(value)}:   {value}");
        }

        public static void IsNegativeInfinity<T>(T value) where T : INumber<T> {
            IsNegativeInfinity(value, string.Empty);
        }

        public static void IsNegativeInfinity<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsNegativeInfinity(value), $"{message}expected:-infinity\n{nameof(value)}:   {value}");
        }

        public static void IsPositive<T>(T value) where T : INumber<T> {
            IsPositive(value, string.Empty);
        }

        public static void IsPositive<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsPositive(value), $"{message}expected:positive\n{nameof(value)}:   {value}");
        }

        public static void IsNegative<T>(T value) where T : INumber<T> {
            IsNegative(value, string.Empty);
        }

        public static void IsNegative<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(T.IsNegative(value), $"{message}expected:negative\n{nameof(value)}:   {value}");
        }

        public static void IsPlusZero<T>(T value) where T : INumber<T> {
            IsPlusZero(value, string.Empty);
        }

        public static void IsPlusZero<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(value == T.Zero && T.IsPositive(value), $"{message}expected:+0\n{nameof(value)}:   {value}");
        }

        public static void IsMinusZero<T>(T value) where T : INumber<T> {
            IsMinusZero(value, string.Empty);
        }

        public static void IsMinusZero<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            Assert.IsTrue(value == T.Zero && T.IsNegative(value), $"{message}expected:-0\n{nameof(value)}:   {value}");
        }
    }
}
