using AppXF.Models;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabForm : VM_TabMain
    {
        /// <summary>
        /// Assign methods to commands
        /// </summary>
        public VM_TabForm()
        {
            ClearFormCommand = new Command(ClearForm);
            AddPersonCommand = new Command(AddPerson);
        }

        string entryName;
        string entrySurname;
        bool labelStatusVisibility;
        public string EntryName
        {
            get { return entryName; }
            set
            {
                entryName = value;
                OnPropertyChanged(nameof(EntryName));
            }
        }
        public string EntrySurname
        {
            get { return entrySurname; }
            set
            {
                entrySurname = value;
                OnPropertyChanged(nameof(EntrySurname));
            }
        }
        public bool LabelStatusVisibility
        {
            get { return labelStatusVisibility; }
            set
            {
                labelStatusVisibility = value;
                OnPropertyChanged(nameof(LabelStatusVisibility));
            }
        }
        public Command ClearFormCommand { get; }
        public Command AddPersonCommand { get; }

        /// <summary>
        /// Clear form when changing tab
        /// </summary>
        void ClearForm()
        {
            EntryName = "";
            EntrySurname = "";
            LabelStatusVisibility = false;
        }

        /// <summary>
        /// Add person to list, display conformation label
        /// </summary>
        void AddPerson()
        {
            MS_Common.People.Add(new M_Person(EntryName, EntrySurname));
            ClearForm();
            LabelStatusVisibility = true;     
        }
    }
}
