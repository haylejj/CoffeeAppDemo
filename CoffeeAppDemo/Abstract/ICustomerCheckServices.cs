using CoffeeAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAppDemo.Abstract
{
    public interface ICustomerCheckServices
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
