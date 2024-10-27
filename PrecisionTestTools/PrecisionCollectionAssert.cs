using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace PrecisionTestTools {
    public static class PrecisionCollectionAssert {
        public static void AreEqual<T>(ICollection<T> expected, ICollection<T> actual) where T : INumber<T> {
            AreEqual(expected, actual, string.Empty);
        }

        public static void AreEqual<T>(ICollection<T> expected, ICollection<T> actual, string message) where T : INumber<T> {
            if (expected.Count != actual.Count) {
                if (!string.IsNullOrEmpty(message)) {
                    message = $"{message}\n";
                }

                throw new AssertFailedException(
                    $"{message}mismatch length\n{nameof(expected)}: {expected.Count}\n{nameof(actual)}:   {actual.Count}"
                );
            }

            long index = 0;
            foreach ((T e, T a) in expected.Zip(actual)) {
                PrecisionAssert.AreEqual(e, a,
                    string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}"
                );
                index++;
            }
        }

        public static void AreEqual<T>(ICollection<T> expected, ICollection<T> actual, T abserr) where T : INumber<T> {
            AreEqual(expected, actual, abserr, string.Empty);
        }

        public static void AreEqual<T>(ICollection<T> expected, ICollection<T> actual, T abserr, string message) where T : INumber<T> {
            if (expected.Count != actual.Count) {
                if (!string.IsNullOrEmpty(message)) {
                    message = $"{message}\n";
                }

                throw new AssertFailedException(
                    $"{message}mismatch length\n{nameof(expected)}: {expected.Count}\n{nameof(actual)}:   {actual.Count}"
                );
            }

            long index = 0;
            foreach ((T e, T a) in expected.Zip(actual)) {
                PrecisionAssert.AreEqual(e, a, abserr,
                    string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}"
                );
                index++;
            }
        }

        public static void AlmostEqual<T>(ICollection<T> expected, ICollection<T> actual, T relerr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, string.Empty);
        }

        public static void AlmostEqual<T>(ICollection<T> expected, ICollection<T> actual, T relerr, string message) where T : INumber<T> {
            if (expected.Count != actual.Count) {
                if (!string.IsNullOrEmpty(message)) {
                    message = $"{message}\n";
                }

                throw new AssertFailedException(
                    $"{message}mismatch length\n{nameof(expected)}: {expected.Count}\n{nameof(actual)}:   {actual.Count}"
                );
            }

            long index = 0;
            foreach ((T e, T a) in expected.Zip(actual)) {
                PrecisionAssert.AlmostEqual(e, a, relerr,
                    string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}"
                );
                index++;
            }
        }

        public static void AlmostEqual<T>(ICollection<T> expected, ICollection<T> actual, T relerr, T abserr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, abserr, string.Empty);
        }

        public static void AlmostEqual<T>(ICollection<T> expected, ICollection<T> actual, T relerr, T abserr, string message) where T : INumber<T> {
            if (expected.Count != actual.Count) {
                if (!string.IsNullOrEmpty(message)) {
                    message = $"{message}\n";
                }

                throw new AssertFailedException(
                    $"{message}mismatch length\n{nameof(expected)}: {expected.Count}\n{nameof(actual)}:   {actual.Count}"
                );
            }

            long index = 0;
            foreach ((T e, T a) in expected.Zip(actual)) {
                PrecisionAssert.AlmostEqual(e, a, relerr, abserr,
                    string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}"
                );
                index++;
            }
        }

        public static void IsNaN<T>(ICollection<T> value) where T : INumber<T> {
            IsNaN(value, string.Empty);
        }

        public static void IsNaN<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsNaN(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsNotNaN<T>(ICollection<T> value) where T : INumber<T> {
            IsNotNaN(value, string.Empty);
        }

        public static void IsNotNaN<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsNotNaN(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsFinite<T>(ICollection<T> value) where T : INumber<T> {
            IsFinite(value, string.Empty);
        }

        public static void IsFinite<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsFinite(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsInfinity<T>(ICollection<T> value) where T : INumber<T> {
            IsInfinity(value, string.Empty);
        }

        public static void IsInfinity<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsInfinity(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsPositiveInfinity<T>(ICollection<T> value) where T : INumber<T> {
            IsPositiveInfinity(value, string.Empty);
        }

        public static void IsPositiveInfinity<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsPositiveInfinity(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsNegativeInfinity<T>(ICollection<T> value) where T : INumber<T> {
            IsNegativeInfinity(value, string.Empty);
        }

        public static void IsNegativeInfinity<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsNegativeInfinity(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsPositive<T>(ICollection<T> value) where T : INumber<T> {
            IsPositive(value, string.Empty);
        }

        public static void IsPositive<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsPositive(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsNegative<T>(ICollection<T> value) where T : INumber<T> {
            IsNegative(value, string.Empty);
        }

        public static void IsNegative<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsNegative(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsPlusZero<T>(ICollection<T> value) where T : INumber<T> {
            IsPlusZero(value, string.Empty);
        }

        public static void IsPlusZero<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsPlusZero(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }

        public static void IsMinusZero<T>(ICollection<T> value) where T : INumber<T> {
            IsMinusZero(value, string.Empty);
        }

        public static void IsMinusZero<T>(ICollection<T> value, string message) where T : INumber<T> {
            long index = 0;
            foreach (T v in value) {
                PrecisionAssert.IsMinusZero(v, string.IsNullOrEmpty(message) ? $"{nameof(index)} = {index}" : $"{message}\n{nameof(index)} = {index}");
                index++;
            }
        }
    }
}
