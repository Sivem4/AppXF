using AppXF.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_TabSettings : ContentPage
    {
        public V_TabSettings()
        {
            InitializeComponent();

            //Setting binding context to viewmodel
            BindingContext = new VM_TabSettings();
        }
    }
}