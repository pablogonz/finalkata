using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kataver3test;

namespace kataver3test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validate_isbn_result_correct()
        {
            string final = "978-1734314502";
            Assert.IsTrue(kataver3.finalisbn.isbnfinal(final));
        }
        [TestMethod]
        public void validate_isbn_result_incorrect()
        {
            string final = "978-173431450adsadada2";
            Assert.IsFalse(kataver3.finalisbn.isbnfinal(final));
        }
    }
}
