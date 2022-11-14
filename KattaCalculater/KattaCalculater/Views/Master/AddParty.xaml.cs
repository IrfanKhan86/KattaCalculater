using KattaCalculater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KattaCalculater.Views.Master
{
    public partial class AddParty : ContentPage
    {
        public AddParty()
        {
            InitializeComponent();
            this.BindingContext = new Party();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
        }
    }
}