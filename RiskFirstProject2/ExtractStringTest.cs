using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace RiskFirstProject2
{
    [TestFixture]
    class ExtractStringTest
    {
        private readonly ExtractString extractString;

        public ExtractStringTest()
        {
            extractString = new ExtractString();
        }

        [Test]
        public void testExtractString()
        {
            string expectedResulst = "to stay";
            string actualResults = extractString.ExtractText("Today is a /* lovely */ weather.Despite that , i decided /* to stay */ at home");
            Assert.AreEqual(expectedResulst.Trim(), actualResults.Trim());
        }
    }
}
                