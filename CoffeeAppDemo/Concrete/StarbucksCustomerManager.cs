using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeAppDemo.Abstract;
using CoffeeAppDemo.Entities;

namespace CoffeeAppDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckServices _customerCheckServices;

        

        public StarbucksCustomerManager(ICustomerCheckServices customerCheckServices)
        {
            _customerCheckServices=customerCheckServices;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckServices.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        

        
    }
}
