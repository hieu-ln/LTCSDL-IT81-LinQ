using System;
using System.Collections.Generic;
using System.Text;

namespace LTCSDL_IT81_LINQ
{
    static class ObjectExtensions
    {
        public static int ReverseDigits(this int i)
        {
            // Translate int into a string, and then
            // get all the characters.
            char[] digits = i.ToString().ToCharArray();
            // Now reverse items in the array.
            Array.Reverse(digits);
            // Put back into string.
            string newDigits = new string(digits);
            // Finally, return the modified string back as an int.
            return int.Parse(newDigits);
        }

    }
}
