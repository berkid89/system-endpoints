using System.Collections.Generic;
using System.Linq;
using SystemEndpoints.Models;

namespace SystemEndpoints
{
    public class Store : IStore
    {
        private Dictionary<string, ServiceAddress> hosts { get; set; } = new Dictionary<string, ServiceAddress>();

        public Store(IEnumerable<Endpoint> hosts)
        {
            this.hosts = hosts.ToDictionary(p => p.alias, p => p.endpoint);
        }

        public string GetServiceAddress(string addr)
        {
            if (!hosts.ContainsKey(addr))
                return addr;

            var result = hosts[addr];

            return result.GetFullUrl();
        }
    }
}
