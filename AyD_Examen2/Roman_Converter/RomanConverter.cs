using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyD_Examen2.Roman_Converter
{
    public class RomanConverter
    {
        public static string IntToRoman(int number)
        {
            if (number > 3999)
                return "Error";

            var roman = "";

            var valoresInts = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var valoresRomanos = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (var i = 0; i < 13; i++)
            {
                while (number >= valoresInts[i])
                {
                    number = number - valoresInts[i];
                    roman = roman + valoresRomanos[i];
                }
            }
            return roman;
        }

        public static int RomanToInt(string roman)
        {
            if (roman.Equals("I was not programmed for that!"))
                return -1;
            if (roman.Equals(""))
                return 0;
            var referenceDictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            roman = roman.ToUpper().Trim();

            for (int i = 0; i < roman.Length; i++)
            {
                if (!referenceDictionary.ContainsKey(roman.ElementAt(i)))
                {
                    return -1;
                }
            }
            if (roman.Contains("IIII") || roman.Contains("VV") || roman.Contains("XXXX") || roman.Contains("LL")
             || roman.Contains("CCCC") || roman.Contains("DD") || roman.Contains("MMMM"))
                return -5;
            int toReturn = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i < roman.Length - 1)
                {
                    if (referenceDictionary[roman.ElementAt(i)] < referenceDictionary[roman.ElementAt(i + 1)])
                    {
                        if (roman.ElementAt(i).Equals('V') || roman.ElementAt(i).Equals('L') ||
                            roman.ElementAt(i).Equals('D'))
                            return -5;
                        toReturn += referenceDictionary[roman.ElementAt(i + 1)] -
                                    referenceDictionary[roman.ElementAt(i)];
                        i++;
                        continue;
                    }
                }
                toReturn += referenceDictionary[roman.ElementAt(i)];
            }
            return toReturn;
        }
    }
}
