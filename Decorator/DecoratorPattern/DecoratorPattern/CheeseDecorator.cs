namespace DecoratorPattern
{
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            var type = base.GetPizzaType();
            return type + " + Extra Cheese!";
        }
    }
}