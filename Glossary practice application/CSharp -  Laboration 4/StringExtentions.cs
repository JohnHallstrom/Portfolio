using System;

namespace CSharpLaborationFourLibrary
{
    public static class StringExtentions
    {
        /// <summary>
        /// Returns a copy of the string with the first character capitalized.
        /// </summary>
        /// <param name="text">The string to provide.</param>
        /// <returns>A string with the first chacater capitalized.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static string Capitalize(this string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
    }
}
