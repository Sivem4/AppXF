using AppXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_TabList : ContentPage
    {
        public V_TabList()
        {
            InitializeComponent();
            BindingContext = new VM_TabList();
        }
    }
}