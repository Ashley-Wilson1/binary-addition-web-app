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
        public string BinaryAdd(string binary1, string binary2)
        {
            char[] sum = new char[Math.Max(binary1.Length, binary2.Length) + 1];
            bool carry = false;

            if (binary2.Length > binary1.Length)
            {
                string c = binary1;
                binary1 = binary2;
                binary2 = c;
            }

            for (int i = binary1.Length - 1, j = binary2.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                char numA = binary1[i];
                char numB = j >= 0 ? binary2[j] : '0';

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

        public string BinarySubtraction(string binary1, string binary2)
        {
            int maxLength = Math.Max(binary1.Length, binary2.Length);
            binary1 = binary1.PadLeft(maxLength, '0');
            binary2 = binary2.PadLeft(maxLength, '0');  // add padding to make the numbers same length

            char borrow = '0';
            string result = "";

            for (int i = maxLength - 1; i >= 0; i--) // right to left for subtraction
            {
                char bit1 = binary1[i];
                char bit2 = binary2[i];

                // Subtract the bits considering the borrow
                if (bit1 == '1' && bit2 == '0')
                {
                    result = (borrow == '1' ? '0' : '1') + result;
                    borrow = '0';
                }
                else if (bit1 == '0' && bit2 == '1')
                {
                    result = (borrow == '1' ? '0' : '1') + result;
                    borrow = '1';
                }
                else if (bit1 == bit2) 
                {
                    result = (borrow == '1' ? '1' : '0') + result;
                    borrow = (bit1 == '0') ? '0' : '1';
                }
            }

            // Remove leading zeros from the result
            result = result.TrimStart('0');

            
            return string.IsNullOrEmpty(result) ? "0" : result; //return 0 is the trimmed result is 0
        }

    }
}
