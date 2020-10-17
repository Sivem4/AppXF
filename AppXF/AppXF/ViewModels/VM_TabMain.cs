using System.ComponentModel;

namespace AppXF.ViewModels
{
    class VM_TabMain : INotifyPropertyChanged
    {
        public VM_TabMain()
        {
                        
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (!(PropertyChanged is null))
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
