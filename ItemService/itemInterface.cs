using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ItemService
{
    [ServiceContract]
    internal interface itemInterface
    {
        [OperationContract]
        DataSet GetItems();

        [OperationContract]
        void AddItem(String item_name, int item_price);

        [OperationContract]
        void UpdateItem(int item_id, int item_price);
    }
}
