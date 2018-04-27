using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RisksFirstProject1
{
    [TestFixture]
    public class PolindromeTest
    {
        private readonly Polidrome polidrome;
        public PolindromeTest()
        {
            polidrome = new Polidrome();
        }

        [Test]
        public void testPolindrome()
        {
            var result = polidrome.IsPalindrome("ma am");
            Assert.IsTrue(result);
        }
    }
}
