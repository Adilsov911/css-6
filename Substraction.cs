using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    internal sealed class Substraction : Calculation
    {
        public override int Number(int number1,int number2)
        {
            return number1-number2;
        }
    }
}
