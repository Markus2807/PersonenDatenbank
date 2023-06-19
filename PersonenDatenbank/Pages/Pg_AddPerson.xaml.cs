
namespace PersonenDatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
    public Pg_AddPerson()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object Sender, EventArgs E)
    {
        lbl_Hello_MAUI.TextColor = Colors.Green;
    }

    private void Button_Released(object sender, EventArgs e)
    {
        lbl_Hello_MAUI.TextColor = Colors.Red;
    }
}