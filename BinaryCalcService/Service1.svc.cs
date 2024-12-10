using BinaryCalcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BinaryCalcService
{
    public class Service1 : IService1
    {
        public double BinaryAdd(double n1, double n2)
        {
            return n1 + n2;
        }
        
    }
}
