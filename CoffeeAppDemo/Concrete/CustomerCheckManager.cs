using CoffeeAppDemo.Abstract;
using CoffeeAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAppDemo.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckServices
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
