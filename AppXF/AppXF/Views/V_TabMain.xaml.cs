﻿using AppXF.ViewModels;
using Xamarin.Forms;

namespace AppXF.Views
{
    public partial class V_TabMain : TabbedPage
    {
        public V_TabMain()
        {
            InitializeComponent();

            //Setting binding context to viewmodel
            BindingContext = new VM_TabMain();
        }
    }
}
