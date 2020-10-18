using AppXF.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabSettings : VM_BasePage
    {
        /// <summary>
        /// Assign methods to commands
        /// </summary>
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
                if (themeSwitchStatus != value)
                {
                    themeSwitchStatus = value;
                    OnPropertyChanged(nameof(ThemeSwitchStatus));
                }
            }
        }
        public Command ChangeThemeCommand { get; }

        /// <summary>
        /// Switch themes in runtime
        /// </summary>
        void ChangeTheme()
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                if (ThemeSwitchStatus)
                {
                    mergedDictionaries.Add(new DarkTheme());
                }
                else
                {
                    mergedDictionaries.Add(new LightTheme());
                }
            }
        }
    }
}
