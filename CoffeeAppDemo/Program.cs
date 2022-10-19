using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeAppDemo.Abstract;
using CoffeeAppDemo.Adapters;
using CoffeeAppDemo.Concrete;
using CoffeeAppDemo.Entities;


namespace CoffeeAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager =new StarbucksCustomerManager(new MernisServiceAdapter());


            Customer customer = new Customer();
            customer.FirstName="Çağatay Berk";
            customer.LastName="Cingiz";
            customer.Id=1;
            customer.NationalityId="";
            customer.DateOfBirth=new DateTime(2001, 11, 5);

            customerManager.Save(customer);

           
          
           
        }
    }
}
