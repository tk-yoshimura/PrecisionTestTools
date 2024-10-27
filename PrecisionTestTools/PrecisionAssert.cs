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
                if (!T.IsInfinity(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                if (T.Sign(expected) != T.Sign(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                return;
            }

            if (T.IsNaN(expected)) {
                if (!T.IsNaN(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }
            }
            else if (expected != actual) {
                throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
            }
        }

        public static void AreEqual<T>(T expected, T actual, T abserr) where T : INumber<T> {
            AreEqual(expected, actual, abserr, string.Empty);
        }

        public static void AreEqual<T>(T expected, T actual, T abserr, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsInfinity(expected)) {
                if (!T.IsInfinity(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                if (T.Sign(expected) != T.Sign(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                return;
            }

            if (T.IsNaN(expected) != T.IsNaN(actual)) {
                throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
            }

            T abserr_actual = T.Abs(expected - actual);
            if (T.Abs(expected - actual) > abserr) {
                throw new AssertFailedException(
                    $"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}\n" +
                    $"abserr:   {abserr_actual:e8}"
                );
            }
        }

        public static void AlmostEqual<T>(T expected, T actual, T relerr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, string.Empty);
        }

        public static void AlmostEqual<T>(T expected, T actual, T relerr, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsInfinity(expected)) {
                if (!T.IsInfinity(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                if (T.Sign(expected) != T.Sign(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                return;
            }

            if (T.IsNaN(expected) != T.IsNaN(actual)) {
                throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
            }

            T abserr_actual = T.Abs(expected - actual);
            T delta = T.Abs(expected) * relerr;
            if (abserr_actual > delta) {
                T relerr_actual = abserr_actual / expected;

                throw new AssertFailedException(
                    $"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}\n" +
                    $"{nameof(relerr)}:   {relerr_actual:e8}"
                );
            }
        }

        public static void AlmostEqual<T>(T expected, T actual, T relerr, T abserr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, abserr, string.Empty);
        }

        public static void AlmostEqual<T>(T expected, T actual, T relerr, T abserr, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsInfinity(expected)) {
                if (!T.IsInfinity(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                if (T.Sign(expected) != T.Sign(actual)) {
                    throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
                }

                return;
            }

            if (T.IsNaN(expected) != T.IsNaN(actual)) {
                throw new AssertFailedException($"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}");
            }

            T abserr_actual = T.Abs(expected - actual);
            T delta = T.Abs(expected) * relerr + abserr;
            if (abserr_actual > delta) {
                T relerr_actual = abserr_actual / expected;

                throw new AssertFailedException(
                    $"{message}{nameof(expected)}: {expected}\n{nameof(actual)}:   {actual}\n" +
                    $"{nameof(relerr)}:   {relerr_actual:e8}\n" +
                    $"{nameof(abserr)}:   {abserr_actual:e8}"
                );
            }
        }

        public static void IsNaN<T>(T value) where T : INumber<T> {
            IsNaN(value, string.Empty);
        }

        public static void IsNaN<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!T.IsNaN(value)) {
                throw new AssertFailedException($"{message}expected: {double.NaN}\n{nameof(value)}:    {value}");
            }
        }

        public static void IsNotNaN<T>(T value) where T : INumber<T> {
            IsNotNaN(value, string.Empty);
        }

        public static void IsNotNaN<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsNaN(value)) {
                throw new AssertFailedException($"{message}expected: not {double.NaN}\n{nameof(value)}:    {value}");
            }
        }

        public static void IsFinite<T>(T value) where T : INumber<T> {
            IsFinite(value, string.Empty);
        }

        public static void IsFinite<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!T.IsFinite(value)) {
                throw new AssertFailedException($"{message}expected: finite\n{nameof(value)}:    {value}");
            }
        }

        public static void IsInfinity<T>(T value) where T : INumber<T> {
            IsInfinity(value, string.Empty);
        }

        public static void IsInfinity<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!T.IsInfinity(value)) {
                throw new AssertFailedException($"{message}expected: {double.PositiveInfinity}\n{nameof(value)}:    {value}");
            }
        }

        public static void IsPositiveInfinity<T>(T value) where T : INumber<T> {
            IsPositiveInfinity(value, string.Empty);
        }

        public static void IsPositiveInfinity<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!T.IsPositiveInfinity(value)) {
                throw new AssertFailedException($"{message}expected: {double.PositiveInfinity}\n{nameof(value)}:    {value}");
            }
        }

        public static void IsNegativeInfinity<T>(T value) where T : INumber<T> {
            IsNegativeInfinity(value, string.Empty);
        }

        public static void IsNegativeInfinity<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!T.IsNegativeInfinity(value)) {
                throw new AssertFailedException($"{message}expected: {double.NegativeInfinity}\n{nameof(value)}:    {value}");
            }
        }

        public static void IsPositive<T>(T value) where T : INumber<T> {
            IsPositive(value, string.Empty);
        }

        public static void IsPositive<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsNaN(value) || !T.IsPositive(value)) {
                throw new AssertFailedException($"{message}expected: positive\n{nameof(value)}:    {value}");
            }
        }

        public static void IsNegative<T>(T value) where T : INumber<T> {
            IsNegative(value, string.Empty);
        }

        public static void IsNegative<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (T.IsNaN(value) || !T.IsNegative(value)) {
                throw new AssertFailedException($"{message}expected: negative\n{nameof(value)}:    {value}");
            }
        }

        public static void IsPlusZero<T>(T value) where T : INumber<T> {
            IsPlusZero(value, string.Empty);
        }

        public static void IsPlusZero<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!(value == T.Zero && T.IsPositive(value))) {
                throw new AssertFailedException($"{message}expected: +0\n{nameof(value)}:    {value}");
            }
        }

        public static void IsMinusZero<T>(T value) where T : INumber<T> {
            IsMinusZero(value, string.Empty);
        }

        public static void IsMinusZero<T>(T value, string message) where T : INumber<T> {
            if (!string.IsNullOrEmpty(message)) {
                message = $"{message}\n";
            }

            if (!(value == T.Zero && T.IsNegative(value))) {
                throw new AssertFailedException($"{message}expected: -0\n{nameof(value)}:    {value}");
            }
        }
    }
}
