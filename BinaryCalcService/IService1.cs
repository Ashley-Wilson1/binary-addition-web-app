using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BinaryCalcService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string BinaryAdd(string n1, string n2);
        string BinarySubtraction(string n1, string n2);


    }
}
