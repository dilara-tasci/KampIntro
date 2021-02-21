using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerManager
    {
        private ICustomerCheckManager _customerCheckManager;
        public CustomerManager(ICustomerCheckManager customerCheckManager)
        {
            _customerCheckManager = customerCheckManager;
        }
        public void Save(Customer customer)
        {
            if (_customerCheckManager.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Saved to db: " + customer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        
        public void Update(Customer customer)
        {
            if (_customerCheckManager.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Updated to db: " + customer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        public void Delete(Customer customer)
        {
            if (_customerCheckManager.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Deleted from db: " + customer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
