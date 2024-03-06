using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    [ServiceContract]
    internal interface customerInterface
    {
        [OperationContract]
        DataSet GetCustomers();

        [OperationContract]
        void AddCustomer(String cust_name, long cust_ph_num);

        [OperationContract]
        Customer GetCustByPhn(long cust_ph_num);
    }
}
