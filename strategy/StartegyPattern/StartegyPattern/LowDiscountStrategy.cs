using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class LowDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int billAmount) => (int) (0.9 * billAmount);
    }
}
