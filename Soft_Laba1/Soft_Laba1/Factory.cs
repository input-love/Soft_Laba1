using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class Factory
    {
        public static NumberSystem createSystem(int numberSystem)
        {
            if(numberSystem < 10)
            {
                return new SimpleNumSys();
            }
            else
            {
                return new ComplexNumSys();
            }
        }
    }
}
