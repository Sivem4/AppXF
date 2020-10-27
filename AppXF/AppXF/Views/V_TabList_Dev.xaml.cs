using AppXF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_TabList_Dev : ContentPage
    {
        public V_TabList_Dev()
        {
            InitializeComponent();
            BindingContext = new VM_TabList_Dev();
        }
    }
}