using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class HighDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int billAmount) => (int) (0.5 * billAmount);
    }
}
