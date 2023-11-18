using UtilityLib.UMath;
using UtilityLib.UString;
using UtilityLib.MathUnits;

namespace UtilityLibTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            TestUtilityMath(999999);

            TestUtilityString("test");
            TestUtilityString("1 5te_8.st 8-3 2");
            TestUtilityString("-_!test");
            TestUtilityString(" test ");
            TestUtilityString(" this is a test   sentence  !  ");

            TestUtilityString(new string[] { "test", "1 5te_8.st 8-3 2", "-_!test-", "  test  ", "hi", "this is a test     sentence    !" });

            TestVector3D();

            TestVector2D();

        }

        public static void TestVector3D()
        {
            Console.WriteLine("### Started testing Vector3D! \n\n-------------------------\n");

            // Test vector creation
            Vector3D vec1 = new Vector3D(1.5, 2, 0.5);
            Console.WriteLine($"Vector1: {vec1.X}, {vec1.Y}, {vec1.Z}");

            // Test vector addition
            Vector3D vec2 = new Vector3D(0.5, 1, 0.2);
            vec1.Add(vec2);
            Console.WriteLine($"Vector1 after addition: {vec1.X}, {vec1.Y}, {vec1.Z}");
            AssertVector3D(vec1, 2, 3, 0.7);

            // Test vector subtraction
            Vector3D vec3 = new Vector3D(1, 2, 0.2);
            vec1.Subtract(vec3);
            Console.WriteLine($"Vector1 after subtraction: {vec1.X}, {vec1.Y}, {vec1.Z}");
            AssertVector3D(vec1, 1, 1, 0.5);

            // Test vector multiplication
            vec1.Multiply(2, 2, 0.5);
            Console.WriteLine($"Vector1 after multiplication: {vec1.X}, {vec1.Y}, {vec1.Z}");
            AssertVector3D(vec1, 2, 2, 0.25);

            // Test vector division
            vec1.Divide(2, 2, 0.5);
            Console.WriteLine($"Vector1 after division: {vec1.X}, {vec1.Y}, {vec1.Z}");
            AssertVector3D(vec1, 1, 1, 0.5);

            // Test vector inversion
            vec1.Invert();
            Console.WriteLine($"Inverted Vector1: {vec1.X}, {vec1.Y}, {vec1.Z}");
            AssertVector3D(vec1, -1, -1, -0.5);

            // Test vector normalization
            Vector3D vec4 = new Vector3D(3, 4, 5);
            vec4.Normalize();
            Console.WriteLine($"Normalized Vector4: {vec4.X}, {vec4.Y}, {vec4.Z}");
            AssertVector3D(vec4, 0.424, 0.566, 0.707);

            Console.WriteLine("\n### Finished testing Vector3D! \n\n-------------------------\n");
        }

        private static void AssertVector3D(Vector3D vector, double expectedX, double expectedY, double expectedZ)
        {
            if (!ApproximatelyEqualV3(vector.X, expectedX) || !ApproximatelyEqualV3(vector.Y, expectedY) || !ApproximatelyEqualV3(vector.Z, expectedZ))
            {
                throw new Exception($"Vector3D assertion failed: Expected ({expectedX}, {expectedY}, {expectedZ}), Actual ({vector.X}, {vector.Y}, {vector.Z})");
            }
        }

        private static bool ApproximatelyEqualV3(double a, double b, double tolerance = 0.001)
        {
            return Math.Abs(a - b) < tolerance;
        }

        public static void TestVector2D()
        {
            Console.WriteLine("### Started testing Vector2D! \n\n-------------------------\n");

            // Test vector creation
            Vector2D vec1 = new Vector2D(1.5, 2);
            Console.WriteLine($"Vector1: {vec1.X}, {vec1.Y}");

            // Test vector addition
            Vector2D vec2 = new Vector2D(0.5, 1);
            vec1.Add(vec2);
            Console.WriteLine($"Vector1 after addition: {vec1.X}, {vec1.Y}");
            AssertVector2D(vec1, 2, 3);

            // Test vector subtraction
            Vector2D vec3 = new Vector2D(1, 2);
            vec1.Subtract(vec3);
            Console.WriteLine($"Vector1 after subtraction: {vec1.X}, {vec1.Y}");
            AssertVector2D(vec1, 1, 1);

            // Test vector multiplication
            vec1.Multiply(2, 2);
            Console.WriteLine($"Vector1 after multiplication: {vec1.X}, {vec1.Y}");
            AssertVector2D(vec1, 2, 2);

            // Test vector division
            vec1.Divide(2, 2);
            Console.WriteLine($"Vector1 after division: {vec1.X}, {vec1.Y}");
            AssertVector2D(vec1, 1, 1);

            // Test vector inversion
            vec1.Invert();
            Console.WriteLine($"Inverted Vector1: {vec1.X}, {vec1.Y}");
            AssertVector2D(vec1, -1, -1);

            // Test vector normalization
            Vector2D vec4 = new Vector2D(3, 4);
            vec4.Normalize();
            Console.WriteLine($"Normalized Vector4: {vec4.X}, {vec4.Y}");
            AssertVector2D(vec4, 0.6, 0.8);

            Console.WriteLine("\n### Finished testing Vector2D! \n\n-------------------------\n");
        }

        private static void AssertVector2D(Vector2D vector, double expectedX, double expectedY)
        {
            if (!ApproximatelyEqualV2(vector.X, expectedX) || !ApproximatelyEqualV2(vector.Y, expectedY))
            {
                throw new Exception($"Vector2D assertion failed: Expected ({expectedX}, {expectedY}), Actual ({vector.X}, {vector.Y})");
            }
        }

        private static bool ApproximatelyEqualV2(double a, double b, double tolerance = 0.001)
        {
            return Math.Abs(a - b) < tolerance;
        }

        public static void TestUtilityMath(int maxnumber)
        {
            Console.WriteLine("###Started testing UtilityMath! \n\n-------------------------\n");
            for (int i = 0; i <= maxnumber; i++)
            {
                if (UtilityMath.IsOdd(i) == UtilityMath.IsEven(i)) { throw new Exception($"Number {i} is both Odd and Even! Schroedingers Number Exception!"); }

                if (i == maxnumber) { Console.WriteLine("#IsOdd and IsEven are working! \n\n--------------------------\n"); }

                if (i == 2) { continue; }
                if (UtilityMath.IsEven(i) && UtilityMath.IsPrime(i)) { throw new Exception($"Number {i} is both Prime and Even! I am confused Exception!"); }

                if (i == maxnumber) { Console.WriteLine("#IsPrime is working! \n\n--------------------------\n"); }
            }
            Console.WriteLine("###Finished testing UtilityMath! \n\n-------------------------\n");
        }

        public static void TestUtilityString(string TestString)
        {
            Console.WriteLine("###Started testing UtilityString! single string. \n\n--------------------------\n");

            if (Char.IsLower(UtilityString.UpperFirstChar(TestString)[0])) { throw new Exception("Char is Lowercase even though it should be Uppercase! single string conversion."); }

            Console.WriteLine("#UpperFirstChar is working! \n\n--------------------------\n");

            if (Char.IsLower(UtilityString.UpperEachFirstChar(TestString)[0])) { throw new Exception("Char is Lowercase even though it should be Uppercase! "); }
            Console.WriteLine(UtilityString.UpperEachFirstChar(TestString, true));

            Console.WriteLine("#UpperEachFirstChar is working! \n\n--------------------------\n");

            Console.WriteLine("###Finished testing UtilityString! single string. \n\n--------------------------\n");
        }

        public static void TestUtilityString(string[] TestStrings)
        {
            Console.WriteLine("###Started testing UtilityString! string[] \n\n--------------------------\n");


            foreach (string s in TestStrings)
            {
                if (Char.IsLower(UtilityString.UpperFirstChar(s)[0])) { throw new Exception("Char is Lowercase even though it should be Uppercase! single string conversion each."); }
            }

            List<string> strings = UtilityString.UpperFirstChar(TestStrings).ToList();
            foreach (string s in strings)
            {
                if (Char.IsLower(s[0])) { throw new Exception("Char is Lowercase even though it should be Uppercase! IList string conversion."); }
            }

            Console.WriteLine("#UpperFirstChar is working! \n\n--------------------------\n");

            strings = UtilityString.UpperEachFirstChar(TestStrings, false).ToList();
            foreach (string s in strings)
            {
                if (Char.IsLower(s[0])) { throw new Exception("Char is Lowercase even though it should be Uppercase! IList string conversion"); }
                Console.WriteLine(s);
            }

            Console.WriteLine("#UpperEachFirstChar is working! \n\n-------------------------\n");


            Console.WriteLine("###Finished testing UtilityString! string[] \n\n--------------------------\n");
        }

    }
}