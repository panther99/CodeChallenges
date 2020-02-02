using System;

namespace Library
{
    public class StringPeelerService
    {
        public string RemoveFirstAndLastLetter(string text)
        {
            string trimmedText = text.Trim();
            return trimmedText.Length < 3
                ? null
                : trimmedText.Substring(1, trimmedText.Length - 2);
        }
    }
}
