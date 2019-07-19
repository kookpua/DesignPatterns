using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CNTax : TaxStrategy
    {
        public override double Calculate(double context = 0)
        {
            return context * 6.8;
        }
    }
}
