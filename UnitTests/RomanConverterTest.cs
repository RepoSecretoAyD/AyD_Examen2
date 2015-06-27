using Microsoft.VisualStudio.TestTools.UnitTesting;
using AyD_Examen2.Roman_Converter;

namespace UnitTests
{
    [TestClass]
    public class RomanConverterTest
    {
        [TestMethod]
        public void toIntToRomanSend_0()
        {
            const string expected = "";
            var actual = RomanConverter.IntToRoman(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toIntToRomanSend_1_Expected_I()
        {
            const string expected = "I";
            var actual = RomanConverter.IntToRoman(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toIntToRomanSend_5_Expected_V()
        {
            const string expected = "V";
            var actual = RomanConverter.IntToRoman(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toIntToRomanSend_2012_Expected_MMXII()
        {
            const string expected = "MMXII";
            var actual = RomanConverter.IntToRoman(2012);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toIntToRomanSend_MaxNumeber_3999()
        {
            const string expected = "MMMCMXCIX";
            var actual = RomanConverter.IntToRoman(3999);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toRomanTonInt_send_MMMCMXCIX_expected_max_3999()
        {
            const int expected = 3999;
            var actual = RomanConverter.RomanToInt("MMMCMXCIX");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toIntToRomanSend_123()
        {
            const string expected = "CXXIII";
            var actual = RomanConverter.IntToRoman(123);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toRomanToIntSend_LIX_Expected_59()
        {
            const int expected = 59;
            var actual = RomanConverter.RomanToInt("LIX");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toRomanToIntSend_MXII_Expected_1012()
        {
            const int expected = 1012;
            var actual = RomanConverter.RomanToInt("MXII");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toRomanToIntSend_MMCMXXXVII_Expected_2937()
        {
            const int expected = 2937;
            var actual = RomanConverter.RomanToInt("MMCMXXXVII");
            Assert.AreEqual(expected, actual);
        }
    }
}