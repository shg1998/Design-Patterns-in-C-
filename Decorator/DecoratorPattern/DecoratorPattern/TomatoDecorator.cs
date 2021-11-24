namespace DecoratorPattern
{
    class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            var type = base.GetPizzaType();
            return type + " + Extra Tomato!";
        }
    }
}