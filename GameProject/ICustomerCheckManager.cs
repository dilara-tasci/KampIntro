using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICustomerCheckManager
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
