using System;
using System.Collections.Generic;
using HowTo.ViewModels;
using HowTo.Views;
using Xamarin.Forms;

namespace HowTo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
