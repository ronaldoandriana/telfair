using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Telfair.ViewModels
{
    class RegistrationViewModel : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        string surname;
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
            }
        }
        
        string nid;
        public string NID
        {
            get => nid;
            set
            {
                nid = value;
            }
        }
        
        string username;
        public string UserName
        {
            get => username;
            set
            {
                username = value;
            }
        }
        
        string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
            }
        }
        
        string confirmPassord;
        public string ConfirmPassord
        {
            get => confirmPassord;
            set
            {
                confirmPassord = value;
            }
        }
        
        string email;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Email
        {
            get => email;
            set
            {
                email = value;
            }
        }

    }
}
