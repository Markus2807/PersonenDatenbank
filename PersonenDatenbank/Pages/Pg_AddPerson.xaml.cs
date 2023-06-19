
namespace PersonenDatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
    public Pg_AddPerson()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object Sender, EventArgs E)
    {
        lbl_Hello_MAUI.BackgroundColor = Color.Green;
    }
}