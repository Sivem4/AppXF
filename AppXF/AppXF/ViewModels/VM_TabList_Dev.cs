using AppXF.Models;
using DevExpress.XamarinForms.DataGrid;
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
        public VM_TabList_Dev(DataGridView dataGridView)
        {
            DeletePersonCommand = new Command<M_Person>(async (p) => await DeletePersonAsync(p));
            EditPersonCommand = new Command((g) => EditPerson(dataGridView, SelectedItem));
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
        public M_Person SelectedItem
        {
            get => selectedItem;
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }
        M_Person selectedItem;
        public Command<M_Person> DeletePersonCommand { get; }
        public Command EditPersonCommand { get; }
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
        void EditPerson(DataGridView dataGridView, M_Person selectedItem)
        {
            var editFormPage = new EditFormPage(dataGridView, dataGridView.SelectedItem);
            App.Current.MainPage.Navigation.PushModalAsync(editFormPage);
        }
    }
}
