using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class TaxStrategy
    {
        public abstract double Calculate(double context = 0);
    }
}
