using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class ComplexNumSys : INumberSystem
    {
            // Перевод в систему счисления
        //----------------------------------------------------------------
        public string Convert(int number, int numberSystem)
        {
            string binaryNumber = "";

            while (true)
            {
                int i = number % numberSystem;

                // Если числа в промежутке от 10 до 25, то подставить соответствующую букву
                if (i > 9 && i < 26)
                {
                    binaryNumber = CharArray[i - 10] + binaryNumber;
                }
                else
                {
                    binaryNumber = i + binaryNumber;
                }

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

            // Переменные
        //----------------------------------------------------------------
        // Массив для хранения вспомогательных данных для перевода в систему счисления
        char[] CharArray = 
        {
            'A', 'B', 'C', 'D', 'E', 
            'F', 'G', 'H', 'I', 'J', 
            'K', 'L', 'M', 'N', 'O', 
            'P', 'Q', 'R', 'S', 'T', 
            'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        //----------------------------------------------------------------
    }
}
