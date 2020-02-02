using System;
using System.Linq;

namespace Library
{
    public class VowelCounterService
    {
        public int CountVowels(string text)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return text.ToLower().Where(c => vowels.Contains(c)).Count();
        }
    }
}
