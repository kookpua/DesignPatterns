using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class USTax : TaxStrategy
    {
        public override double Calculate(double context = 0)
        {

            return context * 1.2;
        }
    }
}
