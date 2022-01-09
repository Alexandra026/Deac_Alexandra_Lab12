using Deac_Alexandra_Laboratorul12.Services;
using Deac_Alexandra_Laboratorul12.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deac_Alexandra_Laboratorul12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            //InitializeComponent();

            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
