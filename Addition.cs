using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    internal sealed class Addition : Calculation
    {
        public override int Number()
        {
            return Number2 + Number1;
        }
    }
}
