using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AyD_Examen2.SpellOutCheckAmount
{
    public class CheckAmount
    {
        double Amount { get; set; }
        public CheckAmount(double amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            var integerAndDecimals = SplitNumbersAndDecimals(Amount);
            var listOfNumbers = InsertNumbersInList(integerAndDecimals.Item1);
            var decimals = integerAndDecimals.Item2.ToString(CultureInfo.InvariantCulture);
            var numbersToLetters = "";
            if (listOfNumbers.Count != 0)
            {
                var position = 0;
                var placeValueForOnes = 0;
                foreach (var number in listOfNumbers)
                {
                    if (position == 0 && listOfNumbers.Count == 1 || position == 3 && listOfNumbers.Count == 4 ||
                        position == 6 && listOfNumbers.Count == 7)
                        numbersToLetters = OneDigitNumberToString(number) + " " + PlaceValuesForWholeNumbers(position) + "  " + numbersToLetters;
                    else if (position == 0 || position == 3 || position == 6)
                        placeValueForOnes = number;
                    if (position == 1 || position == 4 || position == 7)
                    {
                        numbersToLetters = GetLettersForTwoDigitNumber(number, placeValueForOnes, position) + numbersToLetters;
                        numbersToLetters = GetLettersForOneDigitNumber(number, placeValueForOnes, position) + numbersToLetters;
                    }
                    if (position == 2 || position == 5 || position == 8 || position == 9)
                        if (number > 0)
                            numbersToLetters = OneDigitNumberToString(number) + " " + PlaceValuesForWholeNumbers(position) + " " + numbersToLetters;
                    position = position + 1;
                }
            }
            else
                numbersToLetters = "ZERO";
            return numbersToLetters.Trim() + (decimals.Equals("0") ? "" : " AND " + decimals + "/100 DOLLARS");
        }

        private static string GetLettersForOneDigitNumber(int number, int placeValueForOnes, int position)
        {
            if (number == 0)
                if (placeValueForOnes > 0)
                    return OneDigitNumberToString(placeValueForOnes) + " " + PlaceValuesForWholeNumbers(position - 1)+" ";
                else if (number == 0 && placeValueForOnes == 0)
                {
                    return GetLettersForNoPlaceValueInOnesOrTens(position);
                }
            return "";
        }

        private static string GetLettersForNoPlaceValueInOnesOrTens(int position)
        {
            if (position == 4)
                return PlaceValuesForWholeNumbers(3)+" ";
            return position == 7 ? PlaceValuesForWholeNumbers(6)+" " : "";
        }

        private static string GetLettersForTwoDigitNumber(int number, int placeValueForOnes, int position)
        {
            if (number == 1)
                return TwoDigitNumberToString(10 + placeValueForOnes, placeValueForOnes) + " " +
                                   PlaceValuesForWholeNumbers(position - 1)+" ";
            if (number >= 2)
                return TwoDigitNumberToString(number, placeValueForOnes) + " " +
                       PlaceValuesForWholeNumbers(position - 1)+" ";
            return "";
        }

        public static Tuple<int, int> SplitNumbersAndDecimals(double number)
        {
            var integers = (int)(Math.Floor(number));
            var decimals = Convert.ToInt32((number - Math.Floor(number)) * 100);
            return Tuple.Create(integers, decimals);
        }

        public static List<int> InsertNumbersInList(int number)
        {
            var listOfNumbreInts = new List<int>();
            while (number > 0)
            {
                var numberToInsert = (number) % 10;
                listOfNumbreInts.Add(numberToInsert);
                number = number / 10;
            }
            return listOfNumbreInts;
        }

        public static string OneDigitNumberToString(int number)
        {
            var numberStringToReturn = SearchInDictionary(NumberDictionaryForTens, number);
            return numberStringToReturn;
        }
        public static string TwoDigitNumberToString(int number, int oneDigits)
        {
            var numberStringReturn = "";
            if (number >= 10 && number < 20)
            {
                numberStringReturn = SearchInDictionary(NumberDictionaryForTens, number);
            }
            else if (number >= 2)
            {
                numberStringReturn = SearchInDictionary(NumberDictionaryForTens, number * 10) + "-" +
                                     SearchInDictionary(NumberDictionaryForTens, oneDigits) + " ";
            }
            return numberStringReturn;
        }

        public static string PlaceValuesForWholeNumbers(int position)
        {
            var placeValuesDictionary = DictionaryForPlaceValues();
            var placeValueStringToReturn = SearchInDictionary(placeValuesDictionary, position);
            return placeValueStringToReturn;
        }

        public static string SearchInDictionary(Dictionary<int, string> dictionary, int numberOrPlaceValueToFind)
        {
            var numberOrPlaceValueToReturn = "";
            foreach (var numberOrPlaceValueToSearch in dictionary.Where(numberOrPlaceValueToSearch => numberOrPlaceValueToFind == numberOrPlaceValueToSearch.Key))
            {
                numberOrPlaceValueToReturn = numberOrPlaceValueToSearch.Value;
            }
            return numberOrPlaceValueToReturn;
        }
        public static Dictionary<int, string> DictionaryForPlaceValues()
        {
            var placeValuesDictionary = new Dictionary<int, string>
            {
                {2, "HUNDRED"},
                {3, "THOUSAND"},
                {5, "HUNDRED"},
                {6, "MILLION"},
                {8, "HUNDRED"},
                {9, "BILLION"}
            };
            return placeValuesDictionary;
        }

        static readonly Dictionary<int, string> NumberDictionaryForTens = new Dictionary<int, string>
        {
            {1, "ONE"},
            {2, "TWO"},
            {3, "THREE"},
            {4, "FOUR"},
            {5, "FIVE"},
            {6, "SIX"},
            {7, "SEVEN"},
            {8, "EIGHT"},
            {9, "NINE"},
            {10, "TEN"},
            {11, "ELEVEN"},
            {12, "TWELVE"},
            {13, "THIRTEEN"},
            {14, "FOURTEEN"},
            {15, "FIFTEEN"},
            {16, "SIXTEEN"},
            {17, "SEVENTEEN"},
            {18, "EIGHTEEN"},
            {19, "NINETEEN"},
            {20, "TWENTY"},
            {30, "THIRTY"},
            {40, "FORTY"},
            {50, "FIFTY"},
            {60, "SIXTY"},
            {70, "SEVENTY"},
            {80, "EIGHTY"},
            {90, "NINETY"}
        };
    }
}