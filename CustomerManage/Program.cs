using CustomerManage.Abstract;
using CustomerManage.Adapter;
using CustomerManage.Concrete;
using CustomerManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateofBirth = new DateTime(2003, 1, 13), FirstName="Ömer Faruk",LastName="Karagöz",NationalityId="59359066700"});
        }
    }
}
