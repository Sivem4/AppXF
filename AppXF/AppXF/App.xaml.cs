using AppXF.Models;
using AppXF.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXF
{
    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {

            get
            {
                if (database == null)
                    {
                        database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                    }
                return database;
            }
        }

        public App()
        {
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
