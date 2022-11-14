using KattaCalculater.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KattaCalculater.ViewModels
{
    public class PartyViewModel
    {
        public List<Party> Parties { get; set; }
        public PartyViewModel()
        {
            Parties = new List<Party>();
            LoadPageDataAsync();
        }

        private void LoadPageDataAsync()
        {
            //Parties.Add(App.Database.GetParty());
        }
    }
}
