
using System.Linq.Expressions;
using PersonenDatenbank.Model;

namespace PersonenDatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
    private Person _Person = new Person();

    public Person Person
    {
        get => _Person;
        set
        {
            _Person = value;
            OnPropertyChanged();
        }
    }
    
    public Pg_AddPerson()
    {
        InitializeComponent();
        BindingContext = this;
        UserBirthDate_Picker.MinimumDate = new DateTime(1900, 01, 01);
        UserBirthDate_Picker.MaximumDate = DateTime.Now.Date;

    }

    private async void AddModify_Clicked(object Sender, EventArgs E)
    {
        string isMarried = Person.IsMarried ? "Verheiratet" : "Unverheiratet";

        var DisplayAlert_Result = await DisplayAlert($"Speichern",
            $"Möchten Sie die folgenden Daten so speicher?\n" +
            $"Name: {Person.UserName}\n" +
            $"Geburtstag: {Person.BirthDate:d}\n" +
            $"Geschlecht: {Person.Gender}\n" +
            $"{isMarried}",
            accept: "Speichern",
            cancel: "Abbrechen");

        if (DisplayAlert_Result == true)
        {
            Save();
        }
    }

    private void Save(
        )
    {
        new Services.ToastService().ShowToast($"{Person.UserName} wurde der Liste hinzugefügt",true);
        
        /// Add Person to List
        ///
        
        /// clear entries
        ///
        this.Person = new Person();
    }

    private void OnUserName_Completed(object Sender, EventArgs E)
    {
       /// Set the new focus to the Birthday DatePicker
       ///
       UserBirthDate_Picker.Focus();
    }

    private void OnGenderSelected(object Sender, EventArgs E)
    {
        Person.Gender = (Gender)((Sender as Picker).SelectedIndex);
    }
}