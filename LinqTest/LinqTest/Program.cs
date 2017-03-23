using System.Diagnostics;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void find()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var result = repository.Find(customerList, 2);
        }
    }
}
