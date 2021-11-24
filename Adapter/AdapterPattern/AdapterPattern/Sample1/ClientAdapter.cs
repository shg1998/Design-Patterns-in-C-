using System.Collections.Generic;

namespace AdapterPattern.Sample1
{
    class ClientAdapter:ThirdPartyAdaptee,IClientAdapter
    {
        public List<string> GetClientAdapterItems() => base.GetThirdPartyItems();
    }
}