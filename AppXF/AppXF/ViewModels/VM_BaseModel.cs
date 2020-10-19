using System.ComponentModel;

namespace AppXF.ViewModels
{
    /// <summary>
    /// Main viewmodel that implements INotifyPropertyChanged and is parent for other viewmodels
    /// </summary>
    abstract class VM_BaseModel : INotifyPropertyChanged
    {
        public VM_BaseModel()
        {
                        
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fire control's event from viewmodel
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
