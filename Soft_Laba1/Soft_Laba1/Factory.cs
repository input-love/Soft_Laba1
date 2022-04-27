using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class Factory
    {
            // Фабричный метод
        //----------------------------------------------------------------
        public static INumberSystem createSystem(int numberSystem)
        {
            // От 2 до 10 - простая система счисления
            // От 11 до 26 - сложная система счисления
            // Можно расширять фабрику для более сложных систем счисления
            if (numberSystem >= 2 && numberSystem <= 10)
            {
                return new SimpleNumSys();
            }
            else if (numberSystem >= 11 && numberSystem <= 26)
            {
                return new ComplexNumSys();
            }
            else
            {
                throw new Exception("Нет подходящего объекта");
            }
        }
        //----------------------------------------------------------------
    }
}
