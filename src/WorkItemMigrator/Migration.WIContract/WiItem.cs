using System.Collections.Generic;

namespace Migration.WIContract
{
    public class WiItem
    {
        public string Type { get; set; }
        public string OriginId { get; set; }
        public int WiId { get; set; } = -1;
        public string BacklogPriority { get; set; } // Added to store Jira rank
        public string StackRank { get; set; } // Added to store Jira rank
        public List<WiRevision> Revisions { get; set; }

        public override string ToString()
        {
            return $"[{Type}]{OriginId}/{WiId}";
        }
    }
}
