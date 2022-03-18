using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class SimpleNumSys : NumberSystem
    {
        string NumberSystem.Convert(int number, int numberSystem)
        {
            string binaryNumber = "";

            while (true)
            {
                binaryNumber = (number % numberSystem) + binaryNumber;

                if (number / numberSystem == 0)
                {
                    break;
                }
                number /= numberSystem;
            }

            return binaryNumber;
        }
    }
}
