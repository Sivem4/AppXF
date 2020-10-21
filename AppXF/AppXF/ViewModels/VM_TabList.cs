using AppXF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            DisplayListCommand = new Command(async () => await DisplayListAsync());
        }
        /// <summary>
        /// Keep track of people in the list
        /// </summary>
        public ObservableCollection<M_Person>  People
        {
            get
            {
                return MS_Common.People;
            }
        }
        public Command<M_Person> DeletePersonCommand { get; }
        public Command DisplayListCommand { get; }

        async Task DeletePersonAsync(M_Person person)
        {
            MS_Common.People.Remove(person);
            await App.Database.DeletePersonAsync(person);
        }
        async Task DisplayListAsync()
        {
            var peopleList = await App.Database.GetPeopleAsync();
            //MS_Common.People = new ObservableCollection<M_Person>(peopleList);

            foreach (var person in peopleList)
            {
                MS_Common.People.Add(person);
            }
        }
    }
}
