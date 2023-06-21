namespace PersonenDatenbank;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("settings", typeof(Pages.Pg_Settings));
    }
}