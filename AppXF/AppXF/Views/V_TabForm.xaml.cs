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
    public partial class V_TabForm : ContentPage
    {
        public V_TabForm()
        {
            InitializeComponent();
            BindingContext = new VM_TabForm();
        }
    }
}