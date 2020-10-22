using AppXF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabList : VM_BaseModel
    {
        /// <summary>
        /// Assign methods to commands
        /// </summary>
        public VM_TabList()
        {
            DeletePersonCommand = new Command<M_Person>(async (p) => await DeletePersonAsync(p));
            LoadListFromDB();
        }
        /// <summary>
        /// Keep track of people in the list
        /// </summary>
        public ObservableCollection<M_Person>  People
        {
            get => MS_Common.People;
            set
            {
                if (MS_Common.People != value)
                {
                    MS_Common.People = value;
                    OnPropertyChanged(nameof(People));
                }
            }
        }
        public Command<M_Person> DeletePersonCommand { get; }
        /// <summary>
        /// Delete person from list and database
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        async Task DeletePersonAsync(M_Person person)
        {
            MS_Common.People.Remove(person);
            await App.Database.DeletePersonAsync(person);
        }
        /// <summary>
        /// Load data from database to list
        /// </summary>
        /// <returns></returns>
        async Task LoadListFromDB()
        {
            var list = await App.Database.GetPeopleAsync();
            People = new ObservableCollection<M_Person>(list);
        }
    }
}
