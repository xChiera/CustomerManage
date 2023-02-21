 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Entities.Customer customer);
    }
}
