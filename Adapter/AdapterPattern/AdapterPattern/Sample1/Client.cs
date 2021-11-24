using System.Collections.Generic;

namespace AdapterPattern.Sample1
{
    class Client
    {
        private readonly IClientAdapter _clientAdapter;
        public Client(IClientAdapter clientAdapter) => _clientAdapter = clientAdapter;
        public List<string> GetListOfClientItems() => 
            this._clientAdapter.GetClientAdapterItems();
    }
}