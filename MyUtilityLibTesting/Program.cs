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

            Vector3D vec1 = new Vector3D(1.5, 2, 0);
            vec1.Invert();
            vec1.Add(vec1);
            Vector3D vec = vec1.Normalized;
            Console.WriteLine(vec.ToString() + "   " + vec.X + " " + vec.Y + " " + vec.Z);
            
            TestUtilityString("test");
            TestUtilityString("1 5te_8.st 8-3 2");
            TestUtilityString("-_!test");
            TestUtilityString(" test ");
            TestUtilityString(" this is a test   sentence  !  ");

            TestUtilityString(new string[] { "test", "1 5te_8.st 8-3 2", "-_!test-", "  test  ", "hi", "this is a test     sentence    !" });



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