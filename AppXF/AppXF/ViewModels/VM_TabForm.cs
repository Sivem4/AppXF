using AppXF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabForm : VM_TabMain
    {
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

        void ClearForm()
        {
            EntryName = "";
            EntrySurname = "";
            LabelStatusVisibility = false;
        }
        void AddPerson()
        {
            var person = new M_Person(EntryName, EntrySurname);
            MS_Common.People.Add(person);
            ClearForm();
            LabelStatusVisibility = true;     
        }
    }
}
