using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonenDatenbank.Model;

public class Person : INotifyPropertyChanged
{
    public string UserName { get; set; }
    public DateTime BirthDate { get; set; }
    private Gender _gender;

    public Gender Gender
    {
        get => _gender;
        set
        {
            _gender = (Gender)value;
            OnPropertyChanged();
        }
    }
    public bool IsMarried { get; set; }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}

public enum Gender : byte
{
    [Description("Weiblich")]
    FEMALE,
    [Description("Männlich")]
    MALE,
    [Description("Keine Angabe")]
    NOT_DEFINED
}