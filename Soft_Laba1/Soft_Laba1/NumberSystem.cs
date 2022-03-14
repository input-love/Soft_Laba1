using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    abstract class NumberSystem
    {
        public abstract string Convert(int number, int numberSystem);
        public virtual string ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            number = new string(charArray);
            return number;
        }
    }
}
