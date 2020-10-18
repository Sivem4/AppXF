using AppXF.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabList : VM_BasePage
    {
        /// <summary>
        /// Assign methods to commands
        /// </summary>
        public VM_TabList()
        {
            DeletePersonCommand = new Command<M_Person>(DeletePerson);
        }
        /// <summary>
        /// Keep track of people in the list
        /// </summary>
        public ObservableCollection<M_Person> People
        {
            get
            {
                return MS_Common.People;
            }
        }
        public Command<M_Person> DeletePersonCommand { get; }

        void DeletePerson(M_Person person)
        {
            MS_Common.People.Remove(person);
        }
    }
}
