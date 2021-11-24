namespace DecoratorPattern
{
    class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            var type = base.GetPizzaType();
            return type + " + Extra Onion!";
        }
    }
}