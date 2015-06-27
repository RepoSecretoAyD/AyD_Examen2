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
            const string expected = "ZERO";
            var actual = new CheckAmount(0).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_1()
        {
            const string expected = "ONE";
            var actual = new CheckAmount(1).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_0_99()
        {
            const string expected = "ZERO AND 99/100 DOLLARS";
            var actual = new CheckAmount(.99).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_10()
        {
            const string expected = "TEN  AND 24/100 DOLLARS";
            var actual = new CheckAmount(10.24).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_17()
        {
            const string expected = "SEVENTEEN  AND 29/100 DOLLARS";
            var actual = new CheckAmount(17.291).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_54()
        {
            const string expected = "FIFTY-FOUR   AND 74/100 DOLLARS";
            var actual = new CheckAmount(54.74).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_134()
        {
            const string expected = "ONE HUNDRED THIRTY -FOUR   AND 11/100 DOLLARS";
            var actual = new CheckAmount(134.11).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_1512()
        {
            const string expected = "ONE THOUSAND  FIVE HUNDRED TWELVE  AND 42/100 DOLLARS";
            var actual = new CheckAmount(1512.42).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_16792()
        {
            const string expected = "SIXTEEN THOUSAND SEVEN HUNDRED NINETY-TWO   AND 99/100 DOLLARS";
            var actual = new CheckAmount(16792.99).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_1010321()
        {
            const string expected = "ONE MILLION  TEN THOUSAND THREE HUNDRED TWENTY-ONE   AND 5/100 DOLLARS";
            var actual = new CheckAmount(1010321.05).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_72193265()
        {
            const string expected = "SEVENTY-TWO  MILLION ONE HUNDRED NINETY-THREE  THOUSAND TWO HUNDRED SIXTY-FIVE   AND 70/100 DOLLARS";
            var actual = new CheckAmount(72193265.7).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_210992265()
        {
            const string expected = "TWO HUNDRED TEN MILLION NINE HUNDRED NINETY-TWO  THOUSAND TWO HUNDRED SIXTY-FIVE   AND 99/100 DOLLARS";
            var actual = new CheckAmount(210992265.99).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenSend_MaxNumber_2147483647()
        {
            const string expected = "TWO BILLION ONE HUNDRED FORTY-SEVEN  MILLION FOUR HUNDRED EIGHTY-THREE  THOUSAND SIX HUNDRED FORTY-SEVEN   AND 10/100 DOLLARS";
            var actual = new CheckAmount(2147483647.10).ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
