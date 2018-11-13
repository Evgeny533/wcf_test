using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleApp4
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        string xmlLoad(string fileName);
    }
}
