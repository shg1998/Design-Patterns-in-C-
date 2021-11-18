using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NoDiscountStrategy:IStrategy
    {
        public int GetFinalBill(int billAmount) => billAmount;
    }
}
