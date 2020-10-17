﻿using AppXF.Themes;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabSettings : VM_TabForm
    {
        /// <summary>
        /// Assign methods to commands
        /// </summary>
        public VM_TabSettings()
        {
            ChangeThemeCommand = new Command(ChangeTheme);
        }
        string themeSwitchLabel;
        bool themeSwitchStatus;

        public string ThemeSwitchLabel
        {
            get { return themeSwitchLabel; }
            set
            {
                themeSwitchLabel = value;
                OnPropertyChanged(nameof(ThemeSwitchLabel));
            }
        }
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

        /// <summary>
        /// Switch themes in runtime
        /// </summary>
        void ChangeTheme()
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                //Before setting new theme, clearing current theme is a must
                mergedDictionaries.Clear();

                if (ThemeSwitchStatus)
                {
                    mergedDictionaries.Add(new LightTheme());
                }
                else
                {
                    mergedDictionaries.Add(new DarkTheme());
                }
            }
        }
    }
}
