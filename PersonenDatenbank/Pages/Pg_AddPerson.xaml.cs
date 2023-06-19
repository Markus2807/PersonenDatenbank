
namespace PersonenDatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
    public Pg_AddPerson()
    {
        InitializeComponent();
        UserBirthDate_Picker.MinimumDate = new DateTime(1900, 01, 01);
        UserBirthDate_Picker.MaximumDate = DateTime.Now.Date;

    }

    private void AddModify_Clicked(object Sender, EventArgs E)
    {
        string UserName = UserName_Entry.Text;
        DateTime BirthDate = UserBirthDate_Picker.Date;
        string UserSex = (string)UserSex_Picker.SelectedItem;
        bool IsMarried = UserIsMerried_Switch.IsChecked;
        string isMarried = IsMarried ? "Verheiratet" : "Unverheiratet";

        DisplayAlert($"Speichern",
            $"Möchten Sie die folgenden Daten so speicher?\n" +
            $"Name: {UserName}\n" +
            $"Geburtstag: {BirthDate:d}\n" +
            $"Geschlecht: {UserSex}\n" +
            $"{isMarried}",
            accept: "Speichern",
            cancel: "Abbrechen");
    }

    private void OnUserName_Completed(object Sender, EventArgs E)
    {
       /// Set the new focus to the Birthday DatePicker
       ///
       UserBirthDate_Picker.Focus();
    }
}