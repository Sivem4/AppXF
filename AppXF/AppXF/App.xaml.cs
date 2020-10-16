using AppXF.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXF
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            InitializeComponent();

            MainPage = new V_TabMain();
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
