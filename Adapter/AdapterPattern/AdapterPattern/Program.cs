using System;
using AdapterPattern.Sample1;
using AdapterPattern.Sample2;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample 1
            //IClientAdapter client = new ClientAdapter();
            //var c = new Client(client);
            //var list = c.GetListOfClientItems();
            //foreach (var s in list) 
            //    Console.WriteLine(s);

            //sample 2

            var adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine(target.GetRequest());

            Console.ReadKey();
        }
    }
}
