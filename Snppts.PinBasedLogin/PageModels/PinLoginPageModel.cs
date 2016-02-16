using System;
using PropertyChanged;
using FreshMvvm;
using Xamarin.Forms;
using System.Threading.Tasks;
using Acr.UserDialogs;
using System.Windows.Input;

namespace Snppts.PinBasedLogin
{
    [ImplementPropertyChanged]
    public class PinLoginPageModel : FreshBasePageModel
    {
        [AlsoNotifyFor("PincodeMasked")]
        public string Pincode { get; set; }

        public string PincodeMasked { get { return string.Empty.PadLeft(Pincode != null ? Pincode.Length : 0, '*'); } }

        public ICommand NumberCommand { get; protected set; }

        public PinLoginPageModel()
        {
            NumberCommand = new Command<string>((key) => EnterNumber(key));
        }

        async Task EnterNumber(string key)
        {
            // Add the key to the input string until we have the max length of 6.
            if (Pincode == null || Pincode.Length < 6)
                Pincode += key;

            // If there's a pin and it's 6 in length we try a login.
            if (Pincode != null && Pincode.Length == 6)
            {
                Pincode = string.Empty;
                await UserDialogs.Instance.AlertAsync("You could do a login here!", "Great success!", "OK").ConfigureAwait(false);
            }
        }
    }
}

