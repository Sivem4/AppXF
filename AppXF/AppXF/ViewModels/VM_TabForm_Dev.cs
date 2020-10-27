using DevExpress.XamarinForms.DataForm;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppXF.ViewModels
{
    class VM_TabForm_Dev : VM_BaseModel
    { 
        public class PersonalInfo : IDataErrorInfo
        {
        const string leftColumnWidth = "40";

        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_name")]
        [DataFormItemPosition(RowOrder = 0)]
        [DataFormTextEditor(InplaceLabelText = "First name")]
        [Required(ErrorMessage = "First Name cannot be empty")]
        public string FirstName { get; set; }
        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelText = "")]
        [DataFormItemPosition(RowOrder = 1)]
        [DataFormTextEditor(InplaceLabelText = "Last name")]
        [Required(ErrorMessage = "Last Name cannot be empty")]
        public string LastName { get; set; }
        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_location")]
        [DataFormItemPosition(RowOrder = 2)]
        [DataFormTextEditor(InplaceLabelText = "Address")]
        [Required(ErrorMessage = "Address cannot be empty")]
        public string Address { get; set; }

        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, EditorWidth = "0.65*", LabelIcon = "editors_location")]
        [DataFormItemPosition(RowOrder = 3, ItemOrderInRow = 0)]
        [DataFormTextEditor(InplaceLabelText = "City")]
        [Required(ErrorMessage = "City cannot be empty")]
        public string City { get; set; }
        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, EditorWidth = "0.35*", EditorMaxWidth = 150, IsLabelVisible = false)]
        [DataFormItemPosition(RowOrder = 3, ItemOrderInRow = 1)]
        [DataFormNumericEditor(InplaceLabelText = "Zip")]
        public int? Zip { get; set; }

        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_phone")]
        [DataFormItemPosition(RowOrder = 6)]
        [DataFormMaskedEditor(Mask = "000 000 000", InplaceLabelText = "Mobile", Keyboard = "Telephone")]
        [Required(ErrorMessage = "Number cannot be empty")]
        [StringLength(10, MinimumLength = 7)]
        public string Mobile { get; set; }

        [DataFormDisplayOptions(LabelWidth = leftColumnWidth, LabelIcon = "editors_email", IsLabelVisible = true)]
        [DataFormItemPosition(RowOrder = 7)]
        [DataFormTextEditor(InplaceLabelText = "Email", Keyboard = "Email")]
        public string Email { get; set; }

        string IDataErrorInfo.Error => String.Empty;
        string IDataErrorInfo.this[string columnName] => String.Empty;
    }
    public VM_TabForm_Dev()
        {
            Model = new PersonalInfo();
        }
        public PersonalInfo Model { get; set; }

    }
}
