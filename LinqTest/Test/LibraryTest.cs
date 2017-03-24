using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class StringExtensionsTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ConvertToTitleCase()
        {
            var source = "the return of the king";
            var expected = "The Return Of The King";

            //var result = StringExtensions.ConvertToTitleCase(source);
            var result = source.ConvertToTitleCase();

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}
