using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class SimpleNumSys : NumberSystem
    {
        public override string Convert(int number, int numberSystem)
        {
            string binaryNumber = "";

            while (true)
            {
                binaryNumber += number % numberSystem;

                if (number / numberSystem == 0)
                {
                    break;
                }
                number = number / numberSystem;
            }

            return ReverseNumber(binaryNumber);
        }
    }
}
