using System.Collections.Generic;
using System.Linq;

namespace AyD_Examen2.Roman_Converter
{
    public class RomanConverter
    {
        static readonly Dictionary<int, string> ArabicToRomanReferenceDictionary = new Dictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"}
        };

        static readonly Dictionary<char, int> RomanToArabicReferenceDictionary = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static string IntToRoman(int number)
        {
            if (number > 3999 || number < 0)
                return "Invalid Input";
            var roman = "";
            
            for (var i = 12; i >= 0; i--)
            {
                while (number >= ArabicToRomanReferenceDictionary.Keys.ElementAt(i))
                {
                    number -= ArabicToRomanReferenceDictionary.Keys.ElementAt(i);
                    roman += ArabicToRomanReferenceDictionary[ArabicToRomanReferenceDictionary.Keys.ElementAt(i)];
                }
            }
            return roman;
        }

        public static int RomanToInt(string roman)
        {
            if (roman.Equals(""))
                return 0;
            roman = roman.ToUpper().Replace(" ", "");
            if (roman.Where((t, i) => !RomanToArabicReferenceDictionary.ContainsKey(roman.ElementAt(i))).Any()
                || roman.Contains("IIII") || roman.Contains("VV") || roman.Contains("XXXX") || roman.Contains("LL")
                || roman.Contains("CCCC") || roman.Contains("DD") || roman.Contains("MMMM"))
            {
                return -1;
            }
            var toReturn = 0;
            for (var i = 0; i < roman.Length; i++)
            {
                if (i < roman.Length - 1)
                {
                    if (RomanToArabicReferenceDictionary[roman.ElementAt(i)] < RomanToArabicReferenceDictionary[roman.ElementAt(i + 1)])
                    {
                        if (!IsValidRomanNumber(roman, i)) return -1;
                        toReturn += RomanToArabicReferenceDictionary[roman.ElementAt(i + 1)] -
                                    RomanToArabicReferenceDictionary[roman.ElementAt(i)];
                        i++;
                        continue;
                    }
                }
                toReturn += RomanToArabicReferenceDictionary[roman.ElementAt(i)];
            }
            return toReturn;
        }

        static bool IsValidRomanNumber(string roman, int i)
        {
            if (roman.ElementAt(i).Equals('V') || roman.ElementAt(i).Equals('L')
                            || roman.ElementAt(i).Equals('D'))
                return false;
            return i <= 0 || (!roman.ElementAt(i - 1).Equals(roman.ElementAt(i)) && !roman.ElementAt(i - 1).Equals('V'));
        }
    }
}
