using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LinqTest
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerid)
        {
            Customer foundCustomer = null;
            //foreach (var c in customerList)
            //{
            //    if (c.CustomerId == customerid)
            //    {
            //        foundCustomer = c;
            //        break;
            //    }
            //}

            //var query = from c in customerList
            //            where c.CustomerId == customerid
            //            select c;


            //foundCustomer = query.First();
            //foundCustomer = customerList.FirstOrDefault(c=>c.CustomerId == customerid);

            //foundCustomer = customerList.FirstOrDefault(c =>
            //{
            //    Debug.WriteLine(c.LastName);
            //    return c.CustomerId == customerid;
            //});

            //foundCustomer = customerList.Where(c =>
            //            c.CustomerId == customerid)
            //            .Skip(1)
            //            .FirstOrDefault();

            foundCustomer = customerList.FirstOrDefault(c =>
                c.CustomerId == customerid);



            return foundCustomer;
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 5);
        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + " " + c.FirtsName);
            return query;
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

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                .ThenBy(c => c.FirtsName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //    .ThenByDescending(c => c.FirtsName);

            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                .ThenBy(c => c.CustomerTypeId);
        }

    }
}
