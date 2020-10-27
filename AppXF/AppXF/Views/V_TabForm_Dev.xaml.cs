using AppXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_TabForm_Dev : ContentPage
    {
        public V_TabForm_Dev()
        {
            InitializeComponent();
            BindingContext = new VM_TabForm_Dev();
        }
    }
}