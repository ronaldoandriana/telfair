using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;



namespace Telfair.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        //private string email;
        //public string Email
        //{
        //    get { return email; }
        //    set
        //    {
        //        email = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("Email"));
        //    }
        //}
        //private string password;
        //public string Password
        //{
        //    get { return password; }
        //    set
        //    {
        //        password = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("Password"));
        //    }
        //}

        string email;

        public string Email
        {
            get => email;
            set
            {
                email = value;

                var args = new PropertyChangedEventArgs(nameof(Email));

                PropertyChanged?.Invoke(this, args);
            }
        }
        string password;
        public string Password
        {
            get => password;

            set
            {
                password = value;

                var args = new PropertyChangedEventArgs(nameof(Password));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (email != "admin" || password != "admin")
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
}
