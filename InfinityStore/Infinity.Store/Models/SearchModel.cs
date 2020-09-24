using System;

namespace Infinity.Store.Models
{
    public class SearchModel
    {
        public long[] CategoryIds { get; set; }

        public string SearchTerm { get; set; }
    }
}
