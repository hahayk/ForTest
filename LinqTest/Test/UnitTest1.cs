using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqTest;
using System.Linq;

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

        [TestMethod]
        public void SortByNameTest()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var result = repository.SortByName(customerList);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirtsName);
        }

        [TestMethod]
        public void SortByNameInverseTest()
        {
            CustomerRepository repositoty = new CustomerRepository();
            var customerList = repositoty.Retrieve();

            var result = repositoty.SortByNameInReverse(customerList);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerId);
            Assert.AreEqual("Baggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirtsName);
        }

        [TestMethod]
        public void SortByTypeTest()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();
            var result = repository.SortByType(customerList);

            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.Last().CustomerTypeId);
        }
        
    }
}
