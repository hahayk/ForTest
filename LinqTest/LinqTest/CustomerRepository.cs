using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerid)
        {
            Customer foundCustomer = null;
            foreach (var c in customerList)
            {
                if (c.CustomerId == customerid)
                {
                    foundCustomer = c;
                    break;
                }
            }
            return foundCustomer;
        }

        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
            {
                new Customer()
                {
                    CustomerId = 1,
                    FirtsName = "Frodo",
                    LastName = "Baggins",
                    EmailAddress = "fb@hob.me",
                    CustomerTypeId = 1
                },
                new Customer()
                {
                    CustomerId = 2,
                    FirtsName = "Bilbo",
                    LastName = "Baggins",
                    EmailAddress = "bb@hob.me",
                    CustomerTypeId = null
                },
                new Customer()
                {
                    CustomerId = 3,
                    FirtsName = "Samwise",
                    LastName = "Gamgee",
                    EmailAddress = "sb@hob.me",
                    CustomerTypeId = 1
                },
                new Customer()
                {
                    CustomerId = 4,
                    FirtsName = "Rosie",
                    LastName = "Coton",
                    EmailAddress = "rc@hob.me",
                    CustomerTypeId = 2
                },
            };
            return custList;
        }
    }
}
