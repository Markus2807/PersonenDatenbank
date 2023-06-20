using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonenDatenbank.Model;

namespace PersonenDatenbank.Pages;

public partial class Pg_Persons : ContentPage
{
    private List<Model.Person> _Persons = new List<Person>();

    public List<Model.Person> Persons
    {
        get => _Persons;
        set
        {
            _Persons = value;
            OnPropertyChanged();
        }
    }
    
    public Pg_Persons()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnDeletePerson_clicked(object Sender, EventArgs E)
    {
        
    }
}