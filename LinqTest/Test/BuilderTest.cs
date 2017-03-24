using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace Test
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            Builder listBuilder = new Builder();

            var result = listBuilder.BuildIntegerSequence();

            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            Builder listBuilder = new Builder();
            var result = listBuilder.BuildStringSequence();
            foreach (var item in result)
            {
                TestContext.WriteLine(item);
            }

            Assert.IsNotNull(result);
        }
    }
}
