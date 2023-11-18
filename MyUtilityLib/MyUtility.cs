namespace MyUtilityLib
{
    public static class UtilityMath
    {

        /// <summary>
        /// Checks if a number is odd.
        /// </summary>
        /// <param name="Input"></param>
        /// <returns><see langword="true"/> if Input is Odd and <see langword="false"/> if Input is not Odd.</returns>
        public static bool IsOdd(int Input)
        {

            if (Input % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Checks if a number is even.
        /// </summary>
        /// <param name="Input"></param>
        /// <returns><see langword="true"/> if Input is Even and <see langword="false"/> if Input is not Even.</returns>
        public static bool IsEven(int Input)
        {

            if (Input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Checks if a number is a prime number
        /// </summary>
        /// <param name="Input"></param>
        /// <returns><see langword="true"/> if Input is a Prime number and <see langword="false"/> if Input is not a Prime number</returns>
        public static bool IsPrime(int Input)
        {

            if (Input == 2) { return true; }
            if (Input <= 1 || Input % 2 == 0) { return false; }

            var boundary = (int)Math.Floor(Math.Sqrt(Input));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (Input % i == 0) { return false; }
            }

            return true;

        }

    }

    public static class UtilityString
    {

        /// <summary>
        /// Changes the first Char of the string to Uppercase
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string UpperFirstChar(string Input)
        {

            char[] chars = Input.ToCharArray();

            for (int i = 0; i < Input.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    chars[i] = chars[i].ToString().ToUpper().ToCharArray()[0];
                    break;
                }
            }

            string result = "";

            foreach (char c in chars) { result += c; }

            return result;

        }

        /// <summary>
        /// Changes the first char of each string in the array to Uppercase
        /// </summary>
        /// <param name="Input"></param>
        /// <returns><see cref="Array"/>[<see cref="string"/>]</returns>
        public static string[] UpperFirstChar(string[] Input)
        {

            string[] result = new string[Input.Length];

            for (int i = 0; i < Input.Length; i++) { result[i] = UpperFirstChar(Input[i]); }

            return result;

        }

    }

}