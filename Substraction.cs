using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    internal sealed class Substraction : Calculation
    {
        public override int Number()
        {
            return Number1 - Number2;
        }
    }
}
