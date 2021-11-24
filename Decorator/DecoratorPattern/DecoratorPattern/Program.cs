using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza onionDecorator = new OnionDecorator(cheeseDecorator);
            Console.WriteLine(onionDecorator.GetPizzaType());
            Console.ReadKey();
        }
    }
}
