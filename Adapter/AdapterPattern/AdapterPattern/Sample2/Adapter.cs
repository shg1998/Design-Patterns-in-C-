namespace AdapterPattern.Sample2
{
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee) => this._adaptee = adaptee;

        public string GetRequest() => $"This is '{this._adaptee.GetSpecificRequest()}'";
    }
}