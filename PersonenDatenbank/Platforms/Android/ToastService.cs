
using Android.Widget;

namespace PersonenDatenbank.Services;

public partial class ToastService
{
    public partial void ShowToast(string message, bool longToast)
    {
        string text = "Hello toast!";
        ToastLength duration = longToast ? ToastLength.Long : ToastLength.Short;

        var toast = Toast.MakeText(Microsoft.Maui.ApplicationModel.Platform.CurrentActivity, message, duration);
        toast.Show();
    }
}