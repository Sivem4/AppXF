using AppXF.Models;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabForm : VM_BaseModel
    {
        /// <summary>
        /// Assign methods to commands
        /// </summary>
        public VM_TabForm()
        {
            ClearFormCommand = new Command(ClearForm);
            AddPersonCommand = new Command(async () => await AddPerson());
        }

        string entryName;
        string entrySurname;
        bool labelStatusVisibility;
        public string EntryName
        {
            get => entryName;
            set
            {
                if (entryName != value)
                {
                    entryName = value;
                    OnPropertyChanged(nameof(EntryName));
                }
            }
        }
        public string EntrySurname
        {
            get => entrySurname;
            set
            {
                if (entrySurname != value)
                {
                    entrySurname = value;
                    OnPropertyChanged(nameof(EntrySurname));
                }
            }
        }
        public bool LabelStatusVisibility
        {
            get => labelStatusVisibility;
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
        /// Clear form when changing tab
        /// </summary>
        async Task ShowLabel(int miliseconds)
        {
            LabelStatusVisibility = true;
            await Task.Delay(miliseconds);
            LabelStatusVisibility = false;
        }

        /// <summary>
        /// Add person to list, database and display conformation label
        /// </summary>
        async Task AddPerson()
        {
            var person = new M_Person() { Name = EntryName, Surname = EntrySurname };
            MS_Common.People.Add(person);
            await App.Database.SavePersonAsync(person);
            ClearForm();
            await ShowLabel(2000);
        }
    }
}
