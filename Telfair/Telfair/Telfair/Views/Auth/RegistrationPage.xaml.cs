﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telfair.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Telfair.Views.Auth
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrationPage : ContentView
	{
		public RegistrationPage ()
		{
            var vm = new RegistrationViewModel();
            this.BindingContext = vm;
            InitializeComponent();
        }
	}
}