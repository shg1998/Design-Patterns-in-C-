using System.Collections.Generic;

namespace AdapterPattern.Sample1
{
    class ThirdPartyAdaptee
    {
        private readonly List<string> _list;
        public ThirdPartyAdaptee() => _list = new List<string>();

        public List<string> GetThirdPartyItems()
        {
            _list.Add("salam");
            _list.Add("man");
            _list.Add("MohammadHossein");
            _list.Add("Hastam");
            _list.Add("Amirkabir");
            return _list;
        } 
    }
}