using System;
using System.Collections.Generic;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexts = new List<Context>();
            for (var i = 0; i < 1000000; i++) // we want to decrease Memory usage using Flyweight Pattern and also handle instantiation of Objects!
            {
                var context = new Context("Args");
                contexts.Add(context);
            }

            Console.WriteLine(contexts.Count);
        }

        interface IFlyweight { }

        class SharedFlyWeight : IFlyweight
        {
            // intrinsic state
            private readonly string _prop1;
            private readonly string _prop2;
            private readonly string _prop3;
            private readonly string _prop4;

            public SharedFlyWeight(string property)
            {
                this._prop1 = property;
                this._prop2 = _prop1 + "sth else";
                this._prop3 = _prop2 + "sth else";
                this._prop4 = _prop3 + "sth else";
            }
        }

        static class FlyweightFactory
        {
            private static Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();
            public static IFlyweight GetFlyweight(string property)
            {
                if (_flyweights.ContainsKey(property)) return _flyweights[property];
                _flyweights.Add(property, new SharedFlyWeight(property));
                return _flyweights[property];
            }
        }

        class Context
        {
            //extrinsic state = unshared
            private string _id;
            private IFlyweight _flyweight;
            public Context(string str)
            {
                this._flyweight = FlyweightFactory.GetFlyweight(str);
                this._id = DateTime.Now.GetHashCode().ToString("x");
            }
        }
    }
}
