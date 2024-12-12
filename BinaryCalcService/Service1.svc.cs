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

            if (binary2.Length > binary1.Length)// make binary1 longer if not already
            {
                string c = binary1;
                binary1 = binary2;
                binary2 = c;
            }

            for (int i = binary1.Length - 1, j = binary2.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                char numA = binary1[i];
                char numB = j >= 0 ? binary2[j] : '0';//if shorter then make the charater 0

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

            if (carry)//if a carry is left over add it to the start
            {
                sum[0] = '1';
                return new string(sum);
            }

            if(new string(sum, 1, sum.Length - 1) == "0" || new string(sum, 1, sum.Length - 1) == "")
            {
                return "0";
            }
            else
            {
                return new string(sum, 1, sum.Length - 1).TrimStart('0'); //remove the extra space reserved for carry bit and trim.

            }
        }

        public string BinarySubtraction(string binary1, string binary2)
        {
            int maxLength = Math.Max(binary1.Length, binary2.Length);
            binary1 = binary1.PadLeft(maxLength, '0');
            binary2 = binary2.PadLeft(maxLength, '0'); //pad smaller to make same size

            string result = ""; 
            bool borrow = false; // Borrow flag for subtraction

            
            for (int i = maxLength - 1; i >= 0; i--) //right to left for sub
            {
                char bit1 = binary1[i];
                char bit2 = binary2[i];

                
                if (borrow)
                {
                    if (bit1 == '1') // Adjust for the previous borrow
                    {
                        bit1 = '0';
                        borrow = false;
                    }
                    else
                    {
                        bit1 = '1'; // If already 0, borrow again
                    }
                }

                if (bit1 == '0' && bit2 == '1') // Borrow is needed
                {
                    borrow = true;
                    result = '1' + result; // 0 - 1 + borrow becomes 1
                }
                else if (bit1 == bit2) 
                {
                    result = '0' + result; 
                }
                else // bit1 is 1 and bit2 is 0
                {
                    result = '1' + result; 
                }
            }

            
            result = result.TrimStart('0');

            
            return string.IsNullOrEmpty(result) ? "0" : result;
        }
    }
}
