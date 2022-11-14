using System;
using System.Collections.Generic;
using System.Text;

namespace KattaCalculater.Models
{
    public class Transaction
    {
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public long KutteCount { get; set; }
        public long Saada { get; set; }
        public long Tode { get; set; }
        public long DesignId { get; set; }
        public long PartyId { get; set; }
    }
}
