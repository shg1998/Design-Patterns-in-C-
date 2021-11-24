namespace DecoratorPattern
{
    class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza) =>
            _pizza = pizza;

        public virtual string GetPizzaType() =>
            this._pizza.GetPizzaType();
    }
}