using System;
using System.Collections.Generic;
using System.Text;

namespace KattaCalculater.Models
{
    public class Name
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PartyId { get; set; }
        public Party Party { get; set; }
    }
}
