using CustomerManage.Abstract;
using CustomerManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage.Concrete
{
    internal class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if( customerCheckService.CheckIfRealPerson(customer))
            { base.Save(customer); }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    
    }
}
