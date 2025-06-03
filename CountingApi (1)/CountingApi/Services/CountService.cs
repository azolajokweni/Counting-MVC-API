using System.Collections.Generic;
using System.Linq;

namespace CountingApi.Services
{
    public class CountService
    {
        public Dictionary<string, int> CountItems(List<string> items)
        {
            return items.GroupBy(x => x)
                        .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}