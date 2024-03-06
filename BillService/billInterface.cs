using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BillService
{
    [ServiceContract]
    internal interface billInterface
    {
        [OperationContract]
        void AddBill(int cust_id, String items, int amount, DateTime date);

        [OperationContract]
        DataSet GetBills();
    }
}
