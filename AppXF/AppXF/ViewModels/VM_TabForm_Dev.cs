using AppXF.Models;
using DevExpress.XamarinForms.DataForm;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXF.ViewModels
{
    class VM_TabForm_Dev : VM_BaseModel
    { 
        public class PersonalInfo : VM_BaseModel, IDataErrorInfo
        {
            const string leftColumnWidth = "40";

            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_name")]
            [DataFormItemPosition(RowOrder = 0)]
            [DataFormTextEditor(InplaceLabelText = "First name")]
            [Required(ErrorMessage = "First Name cannot be empty")]
            public string FirstName
            {
                get => firstName;
                set
                {
                    if (firstName != value)
                    {
                        firstName = value;
                        OnPropertyChanged(nameof(FirstName));
                    }
                }
            }
            string firstName;


            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelText = "")]
            [DataFormItemPosition(RowOrder = 1)]
            [DataFormTextEditor(InplaceLabelText = "Last name")]
            [Required(ErrorMessage = "Last Name cannot be empty")]
            public string LastName
            {
                get => lastName;
                set
                {
                    if (lastName != value)
                    {
                        lastName = value;
                        OnPropertyChanged(nameof(LastName));
                    }
                }
            }
            string lastName;


            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_location")]
            [DataFormItemPosition(RowOrder = 2)]
            [DataFormTextEditor(InplaceLabelText = "Address")]
            [Required(ErrorMessage = "Address cannot be empty")]
            public string Address
            {
                get => address;
                set
                {
                    if (address != value)
                    {
                        address = value;
                        OnPropertyChanged(nameof(Address));
                    }
                }
            }
            string address;


            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, EditorWidth = "0.65*", LabelIcon = "editors_location")]
            [DataFormItemPosition(RowOrder = 3, ItemOrderInRow = 0)]
            [DataFormTextEditor(InplaceLabelText = "City")]
            [Required(ErrorMessage = "City cannot be empty")]
            public string City
            {
                get => city;
                set
                {
                    if (city != value)
                    {
                        city = value;
                        OnPropertyChanged(nameof(City));
                    }
                }
            }
            string city;



            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, EditorWidth = "0.35*", EditorMaxWidth = 150, IsLabelVisible = false)]
            [DataFormItemPosition(RowOrder = 3, ItemOrderInRow = 1)]
            [DataFormNumericEditor(InplaceLabelText = "Zip")]
            public string ZipCode
            {
                get => zipCode;
                set
                {
                    if (zipCode != value)
                    {
                        zipCode = value;
                        OnPropertyChanged(nameof(ZipCode));
                    }
                }
            }
            string zipCode;


            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_phone")]
            [DataFormItemPosition(RowOrder = 4)]
            [DataFormMaskedEditor(Mask = "000 000 000", InplaceLabelText = "Mobile", Keyboard = "Telephone")]
            [Required(ErrorMessage = "Number cannot be empty")]
            [StringLength(10, MinimumLength = 7)]
            public string Mobile
            {
                get => mobile;
                set
                {
                    if (mobile != value)
                    {
                        mobile = value;
                        OnPropertyChanged(nameof(Mobile));
                    }
                }
            }
            string mobile;


            [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_email", IsLabelVisible = true)]
            [DataFormItemPosition(RowOrder = 5)]
            [DataFormTextEditor(InplaceLabelText = "Email", Keyboard = "Email")]
            public string Email
            {
                get => email;
                set
                {
                    if (email != value)
                    {
                        email = value;
                        OnPropertyChanged(nameof(Email));
                    }
                }
            }
            string email;


            string IDataErrorInfo.Error => String.Empty;
            string IDataErrorInfo.this[string columnName] => String.Empty;

        }
        public VM_TabForm_Dev()
            {
                Model = new PersonalInfo();
                AddPersonCommand = new Command(async () => await AddPerson());
                ClearFormCommand = new Command(ClearForm);
            }
            public PersonalInfo Model { get; set; }
            public Command AddPersonCommand { get; }
            public Command ClearFormCommand { get; }

            void ClearForm()
            {
                Model.FirstName = "";
                Model.LastName = "";
                Model.Address = "";
                Model.City = "";
                Model.ZipCode = "";
                Model.Mobile = "";
                Model.Email = "";
            }
            async Task AddPerson()
            {
                var person = new M_Person() { FirstName = Model.FirstName, LastName = Model.LastName };
                MS_Common.People.Add(person);
                await App.Database.SavePersonAsync(person);
                ClearForm();
                //await ShowLabel(2000);
            }

        }
}
