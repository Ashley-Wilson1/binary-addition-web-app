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
        public string BinaryAdd(string n1, string n2)
        {
            char[] sum = new char[Math.Max(n1.Length, n2.Length) + 1];
            bool carry = false;

            if (n2.Length > n1.Length)
            {
                string c = n1;
                n1 = n2;
                n2 = c;
            }

            for (int i = n1.Length - 1, j = n2.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                char numA = n1[i];
                char numB = j >= 0 ? n2[j] : '0';

                Console.WriteLine(numA + " " + numB);

                if (carry)
                {
                    sum[k] = numA == numB ? '1' : '0';
                    carry = numA == '1' || numB == '1';
                }
                else
                {
                    sum[k] = numA == numB ? '0' : '1';
                    carry = numA == '1' && numB == '1';
                }
            }

            if (carry)
            {
                sum[0] = '1';
                return new string(sum);
            }

            return new string(sum, 1, sum.Length - 1);
        }
        
    }
}
