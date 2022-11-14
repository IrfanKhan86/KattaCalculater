using KattaCalculater.ViewModels;
using KattaCalculater.Views;
using KattaCalculater.Views.Master;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KattaCalculater
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            //Routing.RegisterRoute(nameof(AddParty), typeof(AddParty));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
