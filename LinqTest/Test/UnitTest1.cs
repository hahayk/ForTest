using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqTest;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void find()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var result = repository.Find(customerList, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirtsName);
        }

        [TestMethod]
        public void FindTestNotFound()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var result = repository.Find(customerList, 42);
            Assert.IsNull(result);
        }




    }
}
