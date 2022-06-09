using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new ConcreteMediator();
            var c1 = new ConcreteColleage1(m);
            var c2 = new ConcreteColleage2(m);
            m.Colleage1 = c1;
            m.Colleage2 = c2;
            c1.Send("salam");
            c2.Send("manam khoobam");
        }
    }

    abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }

    class  ConcreteMediator:Mediator
    {
        public ConcreteColleage1 Colleage1 { get; set; }

        public ConcreteColleage2 Colleage2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleage1)
            {
                Colleage2.Notify(message);
            }
            else
            {
                Colleage1.Notify(message);
            }
        }
    }

    abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }
    }

    internal class ConcreteColleage1 : Colleague
    {
        public ConcreteColleage1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message) => Mediator.Send(message,this);
        public void Notify(string message)
        {
            Console.WriteLine("ConcreteColleage1 Gets Message: "+message);
        }
    }

    internal class ConcreteColleage2 : Colleague
    {
        public ConcreteColleage2(Mediator mediator) : base(mediator)
        {
        }
        public void Send(string message) => Mediator.Send(message, this);

        public void Notify(string message)
        {
            Console.WriteLine("ConcreteColleage2 Gets Message: " + message);
        }
    }
}
