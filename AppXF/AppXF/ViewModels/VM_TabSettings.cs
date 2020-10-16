using AppXF.Themes;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabSettings : VM_TabForm
    {
        public VM_TabSettings()
        {
            ChangeThemeCommand = new Command(ChangeTheme);
        }
        bool themeSwitchStatus;
        public bool ThemeSwitchStatus
        {
            get { return themeSwitchStatus; }
            set
            {
                themeSwitchStatus = value;
                OnPropertyChanged(nameof(ThemeSwitchStatus));
            }
        }

        public Command ChangeThemeCommand { get; }
        void ChangeTheme()
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new LightTheme());
            }
        }
    }
}
