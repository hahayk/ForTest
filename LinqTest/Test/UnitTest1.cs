using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqTest;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void find()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var result = repository.Find(customerList, 2);
        }




    }
}
