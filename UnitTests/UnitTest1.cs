using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AyD_Examen2.Template_Engine;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TemplateEngineSingleReplacementTest()
        {
            var mapOfVariables = new Dictionary<string, string> {{"name", "Cenk"}};
            var expected = "Hello Cenk";

            var actual = TemplateEngine.Evaluate("Hello {$name}", mapOfVariables);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TemplateEngineMultipleReplacementTest()
        {
            var mapOfVariables = new Dictionary<string, string>
            {
                { "firstName","Cenk" },
                { "lastName","Civici" }
            };
            var expected = "Hello Cenk Civici";
            var actual = TemplateEngine.Evaluate("Hello {$firstName} {$lastName}", mapOfVariables);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(MissingValueException))]
        public void TemplateEngineExceptionTest()
        {
            var mapOfVariables = new Dictionary<string, string>();
            TemplateEngine.Evaluate("Hello {$firstName}", mapOfVariables);
        }

        [TestMethod]
        public void TemplateEngineHeyDawgReplacementTest()
        {
            var mapOfVariables = new Dictionary<string, string> { { "name", "Cenk" } };
            var expected = "Hello {$Cenk}";

            var actual = TemplateEngine.Evaluate("Hello {${$name}}", mapOfVariables);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TemplateEngineHeyDawgMultipleReplacementTest()
        {
            var mapOfVariables = new Dictionary<string, string>
            {
                { "firstName","Cenk" },
                { "lastName","Civici" }
            };
            var expected = "Hello {$Cenk} Civici";

            var actual = TemplateEngine.Evaluate("Hello {${$firstName}} {$lastName}", mapOfVariables);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TemplateEngineHeyDawgLastMultipleReplacementTest()
        {
            var mapOfVariables = new Dictionary<string, string>
            {
                { "firstName","Cenk" },
                { "lastName","Civici" }
            };
            var expected = "Hello Cenk {$Civici}";

            var actual = TemplateEngine.Evaluate("Hello {$firstName} {${$lastName}}", mapOfVariables);
            Assert.AreEqual(expected, actual);
        }
    }
}
