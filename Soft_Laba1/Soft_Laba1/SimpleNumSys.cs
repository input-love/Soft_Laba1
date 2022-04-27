using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class SimpleNumSys : INumberSystem
    {
            // Перевод в систему счисления
        //----------------------------------------------------------------
        public string Convert(int number, int numberSystem)
        {
            string binaryNumber = "";

            while (true)
            {
                binaryNumber = (number % numberSystem) + binaryNumber;

                // Завершение работы цикла, если уже нельзя будет осуществить перевод
                if (number / numberSystem == 0)
                {
                    break;
                }

                number /= numberSystem;
            }

            return binaryNumber;
        }
        //----------------------------------------------------------------
    }
}
