using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeAppDemo.Abstract;
using CoffeeAppDemo.Entities;
using CoffeeAppDemo.MernisServiceReference1;
using CoffeeAppDemo.Concrete;

namespace CoffeeAppDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckServices
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client= new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
