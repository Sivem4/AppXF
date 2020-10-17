using System.ComponentModel;

namespace AppXF.ViewModels
{
    /// <summary>
    /// Main viewmodel that implements INotifyPropertyChanged and is parent for other viewmodels
    /// </summary>
    class VM_TabMain : INotifyPropertyChanged
    {
        public VM_TabMain()
        {
                        
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fire control's event from viewmodel
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (!(PropertyChanged is null))
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
