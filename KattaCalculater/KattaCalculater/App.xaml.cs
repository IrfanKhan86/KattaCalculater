using KattaCalculater.DataContext;
using KattaCalculater.Interfaces;
using KattaCalculater.Services;
using KattaCalculater.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KattaCalculater
{
    public partial class App : Application
    {        
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("KattaDb.db");

            return new AppDbContext(DbPath);
        }
        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
