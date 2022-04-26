using System;
using System.Text.RegularExpressions;

namespace zywave_data.Extensions
{
    public static class StringExtensions
    {
        private static string SpecialCharacters = "[^0-9A-Za-z ]";

        public static bool CaseInsensitiveContains(this string text, string value, StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        public static string ReplaceAt(this string text, string oldText, string newText, StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            int index;

            if ((index = text.IndexOf(oldText, stringComparison)) > -1)
            {
                text = text.Remove(index, oldText.Length).Insert(index, newText);
            }

            return text;
        }

        public static string RemoveSpecialChars(string text)
        {
            return Regex.Replace(text, SpecialCharacters, "", RegexOptions.None);
        }
    }
}