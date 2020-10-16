using AppXF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXF.Views
{
    public partial class V_TabMain : TabbedPage
    {
        public V_TabMain()
        {
            InitializeComponent();
            BindingContext = new VM_TabMain();
        }
    }
}
