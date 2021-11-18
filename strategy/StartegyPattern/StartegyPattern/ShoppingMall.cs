namespace StrategyPattern
{
    public class ShoppingMall
    {
        //private readonly IStrategy _strategy;
        public IStrategy Strategy { get; set; }
        public string CustomerName { get; set; }
        public int BillAmount { get; set; }

        //public ShoppingMall(IStrategy strategy) => 
        //    _strategy = strategy;

        public int GetFinalBill()
        {
            //return _strategy.GetFinalBill(this.BillAmount);
            return this.Strategy.GetFinalBill(this.BillAmount);
        }
    }
}
