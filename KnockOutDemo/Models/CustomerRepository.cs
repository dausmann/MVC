using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockOutDemo.Models
{
    public class CustomerRepository
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            var myDB = new CustomerDBEntities();
            var query = from cust in myDB.Customers
                        select cust;

            return query.ToList();
        }

        public static void InsertCustomer(Customer cust)
        {
            var myDB = new CustomerDBEntities();
            myDB.Customers.Add(cust);
            myDB.SaveChanges();
        }
    }
}