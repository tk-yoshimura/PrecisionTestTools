using System.Numerics;

namespace PrecisionTestTools {
    public static class PrecisionVectorAssert {
        public static void AreEqual<T>((T x, T y) expected, (T x, T y) actual) where T : INumber<T> {
            AreEqual(expected, actual, string.Empty);
        }

        public static void AreEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual) where T : INumber<T> {
            AreEqual(expected, actual, string.Empty);
        }

        public static void AreEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual) where T : INumber<T> {
            AreEqual(expected, actual, string.Empty);
        }

        public static void AreEqual<T>((T x, T y) expected, (T x, T y) actual, string message) where T : INumber<T> {
            PrecisionAssert.AreEqual(expected.x, actual.x, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.AreEqual(expected.y, actual.y, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
        }

        public static void AreEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, string message) where T : INumber<T> {
            PrecisionAssert.AreEqual(expected.x, actual.x, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.AreEqual(expected.y, actual.y, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
            PrecisionAssert.AreEqual(expected.z, actual.z, string.IsNullOrEmpty(message) ? "z" : $"{message}\nz");
        }

        public static void AreEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, string message) where T : INumber<T> {
            PrecisionAssert.AreEqual(expected.x, actual.x, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.AreEqual(expected.y, actual.y, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
            PrecisionAssert.AreEqual(expected.z, actual.z, string.IsNullOrEmpty(message) ? "z" : $"{message}\nz");
            PrecisionAssert.AreEqual(expected.w, actual.w, string.IsNullOrEmpty(message) ? "w" : $"{message}\nw");
        }

        public static void AreEqual<T>((T x, T y) expected, (T x, T y) actual, T abserr) where T : INumber<T> {
            AreEqual(expected, actual, abserr, string.Empty);
        }

        public static void AreEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, T abserr) where T : INumber<T> {
            AreEqual(expected, actual, abserr, string.Empty);
        }

        public static void AreEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, T abserr) where T : INumber<T> {
            AreEqual(expected, actual, abserr, string.Empty);
        }

        public static void AreEqual<T>((T x, T y) expected, (T x, T y) actual, T abserr, string message) where T : INumber<T> {
            PrecisionAssert.AreEqual(expected.x, actual.x, abserr, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.AreEqual(expected.y, actual.y, abserr, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
        }

        public static void AreEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, T abserr, string message) where T : INumber<T> {
            PrecisionAssert.AreEqual(expected.x, actual.x, abserr, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.AreEqual(expected.y, actual.y, abserr, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
            PrecisionAssert.AreEqual(expected.z, actual.z, abserr, string.IsNullOrEmpty(message) ? "z" : $"{message}\nz");
        }

        public static void AreEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, T abserr, string message) where T : INumber<T> {
            PrecisionAssert.AreEqual(expected.x, actual.x, abserr, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.AreEqual(expected.y, actual.y, abserr, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
            PrecisionAssert.AreEqual(expected.z, actual.z, abserr, string.IsNullOrEmpty(message) ? "z" : $"{message}\nz");
            PrecisionAssert.AreEqual(expected.w, actual.w, abserr, string.IsNullOrEmpty(message) ? "w" : $"{message}\nw");
        }

        public static void AlmostEqual<T>((T x, T y) expected, (T x, T y) actual, T relerr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, string.Empty);
        }

        public static void AlmostEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, T relerr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, string.Empty);
        }

        public static void AlmostEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, T relerr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, string.Empty);
        }

        public static void AlmostEqual<T>((T x, T y) expected, (T x, T y) actual, T relerr, string message) where T : INumber<T> {
            T delta = T.Max(T.Abs(expected.x), T.Abs(expected.y)) * relerr;

            AreEqual(expected, actual, delta, message);
        }

        public static void AlmostEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, T relerr, string message) where T : INumber<T> {
            T delta = T.Max(T.Max(T.Abs(expected.x), T.Abs(expected.y)), T.Abs(expected.z)) * relerr;

            AreEqual(expected, actual, delta, message);
        }

        public static void AlmostEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, T relerr, string message) where T : INumber<T> {
            T delta = T.Max(T.Max(T.Abs(expected.x), T.Abs(expected.y)), T.Max(T.Abs(expected.z), T.Abs(expected.w))) * relerr;

            AreEqual(expected, actual, delta, message);
        }

        public static void AlmostEqual<T>((T x, T y) expected, (T x, T y) actual, T relerr, T abserr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, abserr, string.Empty);
        }

        public static void AlmostEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, T relerr, T abserr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, abserr, string.Empty);
        }

        public static void AlmostEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, T relerr, T abserr) where T : INumber<T> {
            AlmostEqual(expected, actual, relerr, abserr, string.Empty);
        }

        public static void AlmostEqual<T>((T x, T y) expected, (T x, T y) actual, T relerr, T abserr, string message) where T : INumber<T> {
            T delta = T.Max(T.Abs(expected.x), T.Abs(expected.y)) * relerr + abserr;

            AreEqual(expected, actual, delta, message);
        }

        public static void AlmostEqual<T>((T x, T y, T z) expected, (T x, T y, T z) actual, T relerr, T abserr, string message) where T : INumber<T> {
            T delta = T.Max(T.Max(T.Abs(expected.x), T.Abs(expected.y)), T.Abs(expected.z)) * relerr + abserr;

            AreEqual(expected, actual, delta, message);
        }

        public static void AlmostEqual<T>((T x, T y, T z, T w) expected, (T x, T y, T z, T w) actual, T relerr, T abserr, string message) where T : INumber<T> {
            T delta = T.Max(T.Max(T.Abs(expected.x), T.Abs(expected.y)), T.Max(T.Abs(expected.z), T.Abs(expected.w))) * relerr + abserr;

            AreEqual(expected, actual, delta, message);
        }


        public static void IsFinite<T>((T x, T y) value) where T : INumber<T> {
            IsFinite(value, string.Empty);
        }

        public static void IsFinite<T>((T x, T y, T z) value) where T : INumber<T> {
            IsFinite(value, string.Empty);
        }

        public static void IsFinite<T>((T x, T y, T z, T w) value) where T : INumber<T> {
            IsFinite(value, string.Empty);
        }

        public static void IsFinite<T>((T x, T y) value, string message) where T : INumber<T> {
            PrecisionAssert.IsFinite(value.x, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.IsFinite(value.y, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
        }

        public static void IsFinite<T>((T x, T y, T z) value, string message) where T : INumber<T> {
            PrecisionAssert.IsFinite(value.x, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.IsFinite(value.y, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
            PrecisionAssert.IsFinite(value.z, string.IsNullOrEmpty(message) ? "z" : $"{message}\nz");
        }

        public static void IsFinite<T>((T x, T y, T z, T w) value, string message) where T : INumber<T> {
            PrecisionAssert.IsFinite(value.x, string.IsNullOrEmpty(message) ? "x" : $"{message}\nx");
            PrecisionAssert.IsFinite(value.y, string.IsNullOrEmpty(message) ? "y" : $"{message}\ny");
            PrecisionAssert.IsFinite(value.z, string.IsNullOrEmpty(message) ? "z" : $"{message}\nz");
            PrecisionAssert.IsFinite(value.w, string.IsNullOrEmpty(message) ? "w" : $"{message}\nw");
        }
    }
}
