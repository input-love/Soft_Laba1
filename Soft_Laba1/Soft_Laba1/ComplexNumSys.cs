using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class ComplexNumSys : NumberSystem
    {
        public override string Convert(int number, int numberSystem)
        {
            string binaryNumber = "";

            while (true)
            {
                int i = number % numberSystem;
                if (i > 9 && i < 26)
                {
                    binaryNumber += CharArray[i - 10];
                }
                else
                {
                    binaryNumber += i;
                }

                if (number / numberSystem == 0)
                {
                    break;
                }
                number = number / numberSystem;
            }

            return ReverseNumber(binaryNumber);
        }

        char[] CharArray = 
            {'A', 'B', 'C', 'D', 'E', 
             'F', 'G', 'H', 'I', 'J', 
             'K', 'L', 'M', 'N', 'O', 
             'P', 'Q', 'R', 'S', 'T', 
             'U', 'V', 'W', 'X', 'Y', 'Z'};
    }
}
