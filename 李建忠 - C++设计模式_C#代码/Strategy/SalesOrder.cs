using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SalesOrder
    {
        TaxStrategy strategy;
        /// <summary>
        /// 未完成 等我后边学了工厂模式
        /// </summary>
        /// <param name="strategyFactory"></param>
        //public SalesOrder(StrategyFactory strategyFactory)
        //{
        //    strategyFactory = strategyFactory.NewStrategy()
        //}
        public double CalculateTax()
        {
            Double context = 0.5;

            double val = strategy.Calculate(context);

            return val;
        }
    }
}
