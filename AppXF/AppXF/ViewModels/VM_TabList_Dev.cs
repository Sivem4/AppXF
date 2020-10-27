using AppXF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabList_Dev : VM_BaseModel
    {
        public VM_TabList_Dev()
        {
            DeletePersonCommand = new Command<M_Person>(async (p) => await DeletePersonAsync(p));
            LoadListFromDB();
        }
        public ObservableCollection<M_Person> People
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
        async Task DeletePersonAsync(M_Person person)
        {
            MS_Common.People.Remove(person);
            await App.Database.DeletePersonAsync(person);
        }
        async Task LoadListFromDB()
        {
            var list = await App.Database.GetPeopleAsync();
            People = new ObservableCollection<M_Person>(list);
        }
    }
}
