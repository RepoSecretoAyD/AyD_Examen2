using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AyD_Examen2.SpellOutCheckAmount;
namespace UnitTests
{
    [TestClass]
    public class SpellOutCheckAmountTest
    {
        [TestMethod]
        public void WhenSend_0()
        {
            var expected = "CERO AND 0/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_1()
        {
            var expected = "ONE   AND 0/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_0_99()
        {
            var expected = "CERO AND 99/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(.99);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_10()
        {
            var expected = "TEN  AND 24/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(10.24);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_17()
        {
            var expected = "SEVENTEEN  AND 29/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(17.291);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_54()
        {
            var expected = "FIFTY-FOUR   AND 74/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(54.74);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_134()
        {
            var expected = "ONE HUNDRED THIRTY -FOUR   AND 11/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(134.11);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_1512()
        {
            var expected = "ONE THOUSAND  FIVE HUNDRED TWELVE  AND 42/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(1512.42);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_16792()
        {
            var expected = "SIXTEEN THOUSAND SEVEN HUNDRED NINETY-TWO   AND 99/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(16792.99);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_1010321()
        {
            var expected = "ONE MILLION  TEN THOUSAND THREE HUNDRED TWENTY-ONE   AND 5/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(1010321.05);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_72193265()
        {
            var expected = "SEVENTY-TWO  MILLION ONE HUNDRED NINETY-THREE  THOUSAND TWO HUNDRED SIXTY-FIVE   AND 70/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(72193265.7);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_210992265()
        {
            var expected = "TWO HUNDRED TEN MILLION NINE HUNDRED NINETY-TWO  THOUSAND TWO HUNDRED SIXTY-FIVE   AND 99/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(210992265.99);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WhenSend_MaxNumber_2147483647()
        {
            var expected = "TWO BILLION ONE HUNDRED FORTY-SEVEN  MILLION FOUR HUNDRED EIGHTY-THREE  THOUSAND SIX HUNDRED FORTY-SEVEN   AND 10/100 DOLLARS";
            var actual = SpellOutCheckAmount.ConvertNumberToStringEquivalentWords(2147483647.10);
            Assert.AreEqual(expected, actual);
        }
    }
}
