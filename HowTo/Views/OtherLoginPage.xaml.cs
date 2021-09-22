using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HowTo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HowTo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OtherLoginPage : ContentPage
    {
        public OtherLoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}
